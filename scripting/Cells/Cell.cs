using Godot;

public abstract class Cell {
    public Vector2I position;
    public abstract Color Color
    {
        get;
    }
}