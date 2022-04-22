# ความเป็นมาของโปรแกรม
- โปรแกรมที่1 คือการเช็คชื่อคนเข้าออกเหมือนในห้องสมุดตอนประถมที่จะต้องมีการเช็คชื่อก่อนเข้า-ออกห้องสมุด โปรแกรมนี้สามารถเช็คคนเข้าออกแล้วเก็บข้อมูลลง DataGridView เพื่อ Export เป็นไฟล์ CSV สามารถเช็คย้อนหลังได้
- โปรแกรมที่2 คือการจองห้องเรียนแบบง่ายๆเพื่อความเข้าใจของผู้จองและยังสามารถเก็บข้อมูลจาก DataGridView และ Export เป็นไฟล์ CSV สามารถเช็คย้อนหลังได้

# วัตถุประสงค์ของโปรแกรม
เพื่อพัฒนาระบบและประเมินประสิทธิภาพของทั้ง2โปรแกรม

# Class Diagram
```mermaid
classDiagram
  Form2 <|--Form1
  CheckList <|--Form2
  Room <|--Form2
  direction LR
  class Form1{
  -Login()
  }
  class Form2{
  -Room()void
  -Checklist()void
  -Exit()void
  }
  class CheckList{
  selectedRow:int
  -Add():void
  -Save As():void
  -Exit():void
  +id() : string
  +titlename() : string
  +name() : string
  +surname() : string
  +date() : string
  +time() : string
  +inout() : string
  }
  class Room{
  selectedRow:int
  -Add():void
  -Save As():void
  -Exit():void
  +A1():void
  +A2():void
  +A3():void
  +A4():void
  +A5():void
  +A6():void
  +A7():void
  +A8():void
  +A9():void
  }
```

# ผู้พัฒนาโปรแกรม
นายก้องภพ ตาดี รหัสนักศึกษา 643450312-2
