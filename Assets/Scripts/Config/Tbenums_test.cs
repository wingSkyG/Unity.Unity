
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
public partial class Tbenums_test
{
    private readonly System.Collections.Generic.Dictionary<int, enums_test> _dataMap;
    private readonly System.Collections.Generic.List<enums_test> _dataList;
    
    public Tbenums_test(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, enums_test>();
        _dataList = new System.Collections.Generic.List<enums_test>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            enums_test _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = enums_test.Deserializeenums_test(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, enums_test> DataMap => _dataMap;
    public System.Collections.Generic.List<enums_test> DataList => _dataList;

    public enums_test GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public enums_test Get(int key) => _dataMap[key];
    public enums_test this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

