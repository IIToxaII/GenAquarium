using Godot;

public class TextureGenerator {
    Cell[,] matrix;

    TextureGenerator(Cell[,] matrix) {
        this.matrix = matrix;
    }

    public Image Generate() {
        return Image.CreateFromData(2,1,false,Image.Format.Rgbaf, new byte[] {0,255,0,255,255,255});
    }

}