// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;

namespace Kaitai
{
    public partial class EqmacMsgs : KaitaiStruct
    {
        public static EqmacMsgs FromFile(string fileName)
        {
            return new EqmacMsgs(new KaitaiStream(fileName));
        }

        public EqmacMsgs(KaitaiStream p__io, KaitaiStruct p__parent = null, EqmacMsgs p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _padding = m_io.ReadBytes((5311328 - 4096));
            _msgs = new List<NetMsgPtr>();
            for (var i = 0; i < 265; i++)
            {
                _msgs.Add(new NetMsgPtr(m_io, this, m_root));
            }
        }
        public partial class NetMsgPtr : KaitaiStruct
        {
            public static NetMsgPtr FromFile(string fileName)
            {
                return new NetMsgPtr(new KaitaiStream(fileName));
            }

            public NetMsgPtr(KaitaiStream p__io, EqmacMsgs p__parent = null, EqmacMsgs p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_msg = false;
                f_name = false;
                f_fields = false;
                _read();
            }
            private void _read()
            {
                _ofsMsg = m_io.ReadU4le();
            }
            private bool f_msg;
            private NetMsg _msg;
            public NetMsg Msg
            {
                get
                {
                    if (f_msg)
                        return _msg;
                    KaitaiStream io = M_Root.M_Io;
                    long _pos = io.Pos;
                    io.Seek((OfsMsg - 4096));
                    _msg = new NetMsg(io, this, m_root);
                    io.Seek(_pos);
                    f_msg = true;
                    return _msg;
                }
            }
            private bool f_name;
            private StrPtr _name;
            public StrPtr Name
            {
                get
                {
                    if (f_name)
                        return _name;
                    _name = (StrPtr) (Msg.MsgName);
                    f_name = true;
                    return _name;
                }
            }
            private bool f_fields;
            private List<MsgField> _fields;
            public List<MsgField> Fields
            {
                get
                {
                    if (f_fields)
                        return _fields;
                    _fields = (List<MsgField>) (Msg.Members.Fields);
                    f_fields = true;
                    return _fields;
                }
            }
            private uint _ofsMsg;
            private EqmacMsgs m_root;
            private EqmacMsgs m_parent;
            public uint OfsMsg { get { return _ofsMsg; } }
            public EqmacMsgs M_Root { get { return m_root; } }
            public EqmacMsgs M_Parent { get { return m_parent; } }
        }
        public partial class MsgField : KaitaiStruct
        {
            public static MsgField FromFile(string fileName)
            {
                return new MsgField(new KaitaiStream(fileName));
            }

            public MsgField(KaitaiStream p__io, EqmacMsgs.NetMembersPtr p__parent = null, EqmacMsgs p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _name = new StrPtr(m_io, this, m_root);
                _type = new StrPtr(m_io, this, m_root);
                _fieldLength = m_io.ReadU4le();
                _fieldPos = m_io.ReadU4le();
                _unk3 = m_io.ReadU4le();
            }
            private StrPtr _name;
            private StrPtr _type;
            private uint _fieldLength;
            private uint _fieldPos;
            private uint _unk3;
            private EqmacMsgs m_root;
            private EqmacMsgs.NetMembersPtr m_parent;
            public StrPtr Name { get { return _name; } }
            public StrPtr Type { get { return _type; } }
            public uint FieldLength { get { return _fieldLength; } }
            public uint FieldPos { get { return _fieldPos; } }
            public uint Unk3 { get { return _unk3; } }
            public EqmacMsgs M_Root { get { return m_root; } }
            public EqmacMsgs.NetMembersPtr M_Parent { get { return m_parent; } }
        }
        public partial class NetMembersPtr : KaitaiStruct
        {
            public NetMembersPtr(uint p_membersAddr, uint p_fieldCount, KaitaiStream p__io, EqmacMsgs.NetMsg p__parent = null, EqmacMsgs p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _membersAddr = p_membersAddr;
                _fieldCount = p_fieldCount;
                f_fields = false;
                _read();
            }
            private void _read()
            {
                _ofsMembers = m_io.ReadU4le();
            }
            private bool f_fields;
            private List<MsgField> _fields;
            public List<MsgField> Fields
            {
                get
                {
                    if (f_fields)
                        return _fields;
                    KaitaiStream io = M_Root.M_Io;
                    long _pos = io.Pos;
                    io.Seek((MembersAddr - 4096));
                    _fields = new List<MsgField>();
                    for (var i = 0; i < FieldCount; i++)
                    {
                        _fields.Add(new MsgField(io, this, m_root));
                    }
                    io.Seek(_pos);
                    f_fields = true;
                    return _fields;
                }
            }
            private uint _ofsMembers;
            private uint _membersAddr;
            private uint _fieldCount;
            private EqmacMsgs m_root;
            private EqmacMsgs.NetMsg m_parent;
            public uint OfsMembers { get { return _ofsMembers; } }
            public uint MembersAddr { get { return _membersAddr; } }
            public uint FieldCount { get { return _fieldCount; } }
            public EqmacMsgs M_Root { get { return m_root; } }
            public EqmacMsgs.NetMsg M_Parent { get { return m_parent; } }
        }
        public partial class StrPtr : KaitaiStruct
        {
            public static StrPtr FromFile(string fileName)
            {
                return new StrPtr(new KaitaiStream(fileName));
            }

            public StrPtr(KaitaiStream p__io, KaitaiStruct p__parent = null, EqmacMsgs p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_str = false;
                _read();
            }
            private void _read()
            {
                _ofsStr = m_io.ReadU4le();
            }
            private bool f_str;
            private string _str;
            public string Str
            {
                get
                {
                    if (f_str)
                        return _str;
                    KaitaiStream io = M_Root.M_Io;
                    long _pos = io.Pos;
                    io.Seek((OfsStr - 4096));
                    _str = System.Text.Encoding.GetEncoding("ASCII").GetString(io.ReadBytesTerm(0, false, true, true));
                    io.Seek(_pos);
                    f_str = true;
                    return _str;
                }
            }
            private uint _ofsStr;
            private EqmacMsgs m_root;
            private KaitaiStruct m_parent;
            public uint OfsStr { get { return _ofsStr; } }
            public EqmacMsgs M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class NetMsg : KaitaiStruct
        {
            public static NetMsg FromFile(string fileName)
            {
                return new NetMsg(new KaitaiStream(fileName));
            }

            public NetMsg(KaitaiStream p__io, EqmacMsgs.NetMsgPtr p__parent = null, EqmacMsgs p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_members = false;
                _read();
            }
            private void _read()
            {
                _msgName = new StrPtr(m_io, this, m_root);
                _unk1 = m_io.ReadU4le();
                _msgMembersAddr = m_io.ReadU4le();
                _msgFieldCount = m_io.ReadU4le();
                _msgSize = m_io.ReadU4le();
            }
            private bool f_members;
            private NetMembersPtr _members;
            public NetMembersPtr Members
            {
                get
                {
                    if (f_members)
                        return _members;
                    _members = new NetMembersPtr(MsgMembersAddr, MsgFieldCount, m_io, this, m_root);
                    f_members = true;
                    return _members;
                }
            }
            private StrPtr _msgName;
            private uint _unk1;
            private uint _msgMembersAddr;
            private uint _msgFieldCount;
            private uint _msgSize;
            private EqmacMsgs m_root;
            private EqmacMsgs.NetMsgPtr m_parent;
            public StrPtr MsgName { get { return _msgName; } }
            public uint Unk1 { get { return _unk1; } }
            public uint MsgMembersAddr { get { return _msgMembersAddr; } }
            public uint MsgFieldCount { get { return _msgFieldCount; } }
            public uint MsgSize { get { return _msgSize; } }
            public EqmacMsgs M_Root { get { return m_root; } }
            public EqmacMsgs.NetMsgPtr M_Parent { get { return m_parent; } }
        }
        private byte[] _padding;
        private List<NetMsgPtr> _msgs;
        private EqmacMsgs m_root;
        private KaitaiStruct m_parent;
        public byte[] Padding { get { return _padding; } }
        public List<NetMsgPtr> Msgs { get { return _msgs; } }
        public EqmacMsgs M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
