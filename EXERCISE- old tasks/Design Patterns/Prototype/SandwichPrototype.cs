namespace Prototype
{
    public abstract class SandwichPrototype
    {
        //if we write return this in the method it points to the memory
        //with this approach we get new copy
        public abstract SandwichPrototype Clone();
    }
}
