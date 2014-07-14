using log4net.Core;
using log4net.Layout.Pattern;
using log4net.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lzw.Common.Log4Net
{
    public class CustomLayout : log4net.Layout.LayoutSkeleton
    {
        public const string DefaultConversionPattern = "%message%newline";
        public const string DetailConversionPattern = "%timestamp [%thread] %level %logger %ndc - %message%newline";
        private static Hashtable s_globalRulesRegistry;
        private string m_pattern;
        private PatternConverter m_head;
        private Hashtable m_instanceRulesRegistry = new Hashtable();
        //这里是重点-------------------------------------------------------
        /// <summary>
        /// 把自定义的字段放进Hashtable
        /// 定义多少个写多少个
        /// 注意这里有名称要和配置文件中的名称一致
        /// 注意命名空间
        /// 在配置文件中要用到命名空间
        /// </summary>
        static CustomLayout()
        {
            s_globalRulesRegistry = new Hashtable(2);
            s_globalRulesRegistry.Add("username", typeof(LoginNamePatternConverter));
            s_globalRulesRegistry.Add("userid", typeof(UserIDPatternConverter));
        }
        //--------------------------------------------------------------------
        public CustomLayout()
            : this(DefaultConversionPattern)
        { }
        public CustomLayout(string pattern)
        {
            IgnoresException = true;
            m_pattern = pattern;
            if (m_pattern == null)
            {
                m_pattern = DefaultConversionPattern;
            }
            ActivateOptions();
        }
        public string ConversionPattern
        {
            get { return m_pattern; }
            set { m_pattern = value; }
        }
        /// <summary>
        /// 对Hashtable中的值进行转换
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        virtual protected PatternParser CreatePatternParser(string pattern)
        {
            PatternParser patternParser = new PatternParser(pattern);
            foreach (DictionaryEntry entry in s_globalRulesRegistry)
            {
                patternParser.PatternConverters[entry.Key] = entry.Value;
            }
            foreach (DictionaryEntry entry in m_instanceRulesRegistry)
            {
                patternParser.PatternConverters[entry.Key] = entry.Value;
            }
            return patternParser;
        }
        override public void ActivateOptions()
        {
            m_head = CreatePatternParser(m_pattern).Parse();

            PatternConverter curConverter = m_head;
            while (curConverter != null)
            {
                PatternLayoutConverter layoutConverter = curConverter as PatternLayoutConverter;
                if (layoutConverter != null)
                {
                    if (!layoutConverter.IgnoresException)
                    {
                        this.IgnoresException = false;

                        break;
                    }
                }
                curConverter = curConverter.Next;
            }
        }
        override public void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (loggingEvent == null)
            {
                throw new ArgumentNullException("loggingEvent");
            }
            PatternConverter c = m_head;
            while (c != null)
            {
                c.Format(writer, loggingEvent);
                c = c.Next;
            }
        }
        public void AddConverter(ConverterInfo converterInfo)
        {
            AddConverter(converterInfo.Name, converterInfo.Type);
        }
        public void AddConverter(string name, Type type)
        {
            if (name == null) throw new ArgumentNullException("name");
            if (type == null) throw new ArgumentNullException("type");

            if (!typeof(PatternConverter).IsAssignableFrom(type))
            {
                throw new ArgumentException("The converter type specified [" + type + "] must be a subclass of log4net.Util.PatternConverter", "type");
            }
            m_instanceRulesRegistry[name] = type;
        }
        public sealed class ConverterInfo
        {
            private string m_name;
            private Type m_type;
            public ConverterInfo()
            { }
            public string Name
            {
                get { return m_name; }
                set { m_name = value; }
            }
            public Type Type
            {
                get { return m_type; }
                set { m_type = value; }
            }
        }
    }
}
