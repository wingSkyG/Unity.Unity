
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg
{
public sealed partial class ClassTest : Luban.BeanBase
{
    public ClassTest(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["childrens"].IsObject) { throw new SerializationException(); }  Childrens = Children.DeserializeChildren(_buf["childrens"]);  }
    }

    public static ClassTest DeserializeClassTest(JSONNode _buf)
    {
        return new ClassTest(_buf);
    }

    public readonly int Id;
    public readonly Children Childrens;
   
    public const int __ID__ = 1994262026;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        Childrens?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "childrens:" + Childrens + ","
        + "}";
    }
}

}

