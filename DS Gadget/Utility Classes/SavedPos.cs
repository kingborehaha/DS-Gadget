
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;

namespace DS_Gadget
{
    public class SavedPos : IComparable<SavedPos>
    {
        

        [XmlAnyElement("NameXmlComment")]
        public XmlComment NameXmlComment { get { return GetType().GetXmlComment(); } set { } }

        [XmlComment("string")]
        public string Name { get; set; }


        [XmlAnyElement("XXmlComment")]
        public XmlComment XXmlComment { get { return GetType().GetXmlComment(); } set { } }

        [XmlComment("decimal")]
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public decimal Z { get; set; }

        public decimal Angle { get; set; }

        [XmlAnyElement("PlayerStateXmlComment")]
        public XmlComment PlayerStateXmlComment { get { return GetType().GetXmlComment(); } set { } }

        [XmlComment("HP & Stam = int. FollowCam is a byte array as Base64")]
        public State.PlayerState PlayerState { get; set; }

        public int CompareTo(SavedPos other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public void Save()
        {
            using (FileStream stream = new FileStream("Resources/SavedPositions.xml", FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(SavedPos));
                XML.Serialize(stream, this);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class XmlCommentAttribute : Attribute
    {
        public XmlCommentAttribute(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }
    }

    public static class XmlCommentExtensions
    {
        const string XmlCommentPropertyPostfix = "XmlComment";

        static XmlCommentAttribute GetXmlCommentAttribute(this Type type, string memberName)
        {
            var member = type.GetProperty(memberName);
            if (member == null)
                return null;
            var attr = member.GetCustomAttribute<XmlCommentAttribute>();
            return attr;
        }

        public static XmlComment GetXmlComment(this Type type, [CallerMemberName] string memberName = "")
        {
            var attr = GetXmlCommentAttribute(type, memberName);
            if (attr == null)
            {
                if (memberName.EndsWith(XmlCommentPropertyPostfix))
                    attr = GetXmlCommentAttribute(type, memberName.Substring(0, memberName.Length - XmlCommentPropertyPostfix.Length));
            }
            if (attr == null || string.IsNullOrEmpty(attr.Value))
                return null;
            return new XmlDocument().CreateComment(attr.Value);
        }
    }
}
