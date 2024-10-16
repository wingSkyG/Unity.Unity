
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
public partial class Tables
{
    public item.TbItem TbItem {get; }
    public TbClassTest TbClassTest {get; }
    public Tbenums_test TbenumsTest {get; }
    public Tbreward Tbreward {get; }

    public Tables(System.Func<string, JSONNode> loader)
    {
        TbItem = new item.TbItem(loader("item_tbitem"));
        TbClassTest = new TbClassTest(loader("tbclasstest"));
        TbenumsTest = new Tbenums_test(loader("tbenums_test"));
        Tbreward = new Tbreward(loader("tbreward"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TbItem.ResolveRef(this);
        TbClassTest.ResolveRef(this);
        TbenumsTest.ResolveRef(this);
        Tbreward.ResolveRef(this);
    }
}

}
