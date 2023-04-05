using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

//Use interface


namespace oop
{
    public class Prob8
    {

    }
}

public interface IPhotoCapture
{
    void CapturePhoto();
}

public class Camera : IPhotoCapture
{
    public void CapturePhoto()
    {
        Console.WriteLine("Taking a photo with the camera.");
    }
}

public class Smartphone : IPhotoCapture
{
    public void CapturePhoto()
    {
        Console.WriteLine("Taking a photo with the smartphone camera.");
    }
}
