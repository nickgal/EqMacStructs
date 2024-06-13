meta:
  id: eqmac_msgs
  endian: le
  encoding: ASCII

types:
  str_ptr:
    -webide-representation: '{str}'
    seq:
      - id: ofs_str
        type: u4
    instances:
      str:
        -webide-parse-mode: eager
        io: _root._io
        pos: (ofs_str - 4096)
        type: strz
  msg_field:
    -webide-representation: '{name} {type}[{field_length:dec}] {field_pos:dec} {unk3}'
    seq:
      - id: name
        type: str_ptr
      - id: type
        type: str_ptr
      - id: field_length
        type: u4
      - id: field_pos # byte position?
        type: u4
      - id: unk3 # maybe the byte swap type (how should it be swapped by MacMsg_ByteSwapMessage)
        type: u4
  net_members_ptr:
    params:
      - id: members_addr
        type: u4
      - id: field_count
        type: u4
    seq:
      - id: ofs_members
        type: u4
    instances:
      fields:
        -webide-parse-mode: eager
        io: _root._io
        pos: (members_addr - 4096)
        type: msg_field
        repeat: expr
        repeat-expr: field_count
  net_msg_ptr:
    -webide-representation: '{name}'
    seq:
      - id: ofs_msg
        type: u4
    instances:
      msg:
        -webide-parse-mode: eager
        io: _root._io
        pos: (ofs_msg - 4096)
        type: net_msg
      name:
        value: msg.msg_name
      fields:
        value: msg.members.fields
  net_msg:
    -webide-representation: '{msg_size:dec} bytes {msg_field_count:dec} fields'
    seq:
      - id: msg_name
        type: str_ptr
      - id: unk1
        type: u4
      - id: msg_members_addr
        type: u4
      - id: msg_field_count
        type: u4
      - id: msg_size
        type: u4
    instances:
      members:
        type: net_members_ptr(msg_members_addr, msg_field_count)

seq:
  - id: padding
    size: (0x510b60 - 4096)
  - id: msgs
    type: net_msg_ptr
    repeat: expr
    repeat-expr: 265
