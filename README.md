# CSharp.DesignPatterns.4.Creational.Singletons

es un objeto que solo puede instanciarse una vez, juega con metodos y atritubos statics y not statics para hacer esto

1. el constructor es privado
```csharp
private Singleton()
{
}
```
2. la instancia es estatica y private
```csharp
private static Singleton instance;
```
3. el metodo principal que vuelve singleton a la clase (GetInstance) revisa si se instancio la clase, sino lo hizo lo hace en este momento, y si ya esta instanciado devuelve la anterior instancia

Se crea el metodo GetInstance:
si la instancia es nula se crea una instancia, si no es nula se mantiene la instancia existente
(puedes revisar https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator para entender este operador: ??)
```csharp
instance ??= new Singleton();
```
4. Para crear la instancia sin uso del keyword new, porque no tiene constructor:
```csharp
Singleton s1 = Singleton.GetInstance();
```
