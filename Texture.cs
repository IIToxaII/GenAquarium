using Godot;
using System;
using System.Collections.Generic;

public partial class Texture : Polygon2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var green = new Color(0,1,0);
		var white = new Color(1,1,1);
		var dataList = new List<byte>();
		dataList.AddRange(UintToBytes(white.ToRgba32()));
		dataList.AddRange(UintToBytes(green.ToRgba32()));
		// GD.Print(String.Join(',', dataList.ToArray()));
		GD.Print(String.Join(',', UintToBytes(green.ToRgba32())));
		var texture = ImageTexture.CreateFromImage(Image.CreateFromData(2,1,false,Image.Format.Rgba8, dataList.ToArray()));
		Texture = texture;
	}

	private byte[] UintToBytes(uint source) 
	{
		var bytes = BitConverter.GetBytes(source);
		if (BitConverter.IsLittleEndian)
    		Array.Reverse(bytes);

		return bytes;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
