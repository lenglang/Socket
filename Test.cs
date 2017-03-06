using System; 
using System.IO;
using UnityEngine;
/// <summary>
/// Socket使用，参考地址：http://www.jb51.net/article/82795.htm
/// </summary>
public class Test : MonoBehaviour
{
    void Start()
    {
        //创建对象   
        NetModel item = new NetModel() { ID = 1, Commit = "LanOu", Message = "Unity" };
        //序列化对象   
        byte[] temp = ProtobufTool.Serialize<NetModel>(item);
        //ProtoBuf的优势一：小  
        Debug.Log(temp.Length);
        //反序列化为对象   
        NetModel result = ProtobufTool.DeSerialize<NetModel>(temp);
        Debug.Log(result.Message);
    }
    
}
