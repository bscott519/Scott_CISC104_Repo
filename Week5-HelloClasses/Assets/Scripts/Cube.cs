using System;

public class Cube
{
    private float length;
    private float width;
    private float height;

    public Cube()
    {
        length = 0f;
        width = 0f;
        height = 0f;
    }

    public Cube (float newLength, float newWidth, float newHeight)
    {
        length = newLength;
        width = newWidth;
        height = newHeight;
    }

    public float GetVolume()
    {
        return length * width * height;
    }

    public float GetEdgeLength()
    {
        return (float)Math.Cbrt(length * width * height);
    }

    public float GetLength()
    {
        return length;
    }

    public void SetLength(float newLength)
    {
        length = newLength;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }
}
