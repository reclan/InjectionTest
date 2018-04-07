namespace InjectionTest.Test{
    public class Sample : ISample{
        public string[] GetValues(){
            return new[]{"Injection", "Works"};
        }
    }
}