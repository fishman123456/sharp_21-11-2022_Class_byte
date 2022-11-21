
internal class Byte_one_two
{
    public byte _byte1 { get; set; }
    public byte _byte2 { get; set; }
    public Byte_one_two() { } // TODO конструктор без параметров

    public Byte_one_two(byte byte1, byte byte2) // TODO конструктор с параметрами
    {
        this._byte1 = byte1;
        this._byte2 = byte2;
    }


    //HACK это хак - некая временная затычка которую надо исправить
    //UNDONE очевидно, не доделано

    public override string ToString()
    {
        return $"\n Байт №1 : {_byte1}\t №2 : {_byte2}\n";
    }

}

