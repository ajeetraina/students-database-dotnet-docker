namespace projectone;
public class Class1
{
    public string Serilizestring(string input){
        return Newtonsoft.Json.JsonConvert.SerializeObject(input);
    }
}
