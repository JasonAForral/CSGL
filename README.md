# CSGL
CSGL was created to provide a simple, low-level OpenGL loader for the OpenGL 1.0 thru 4.5 specification.
CSGL provides a P/Invoke wrapper for GLFW3 as well, as it uses it internally to fetch the process addresses.  

### Setup
 - Add `CSGL.cs` to your project.
 - Skip ahead to `Usage` if you would like to use **OpenGL 4.5**.
 - Open up `CSGL.cs` and start a multiline comment at **the version one above** the OpenGL version you would like to use.
 - End the multiline comment at the end (under the OpenGL 4.5 region).  
  
### Usage
 - (Optional) Add using directives:
```csharp
using static CSGL;        // csgl*
using static CSGL.Glfw3;  // glfw*
using static CSGL.OpenGL; // gl*
```  
`using static` requires **C#6** or higher.
 - Create an OpenGL context:
```csharp
glfwInit();
glfwWindowHint( GLFW_CONTEXT_VERSION_MAJOR, 4 ); // Change this to your targeted major version
glfwWindowHint( GLFW_CONTEXT_VERSION_MINOR, 5 ); // Change this to your targeted minor version

IntPtr window = glfwCreateWindow( 640, 480, "CSGL Window", IntPtr.Zero, IntPtr.Zero );

glfwMakeContextCurrent( window );
```  
  - Load OpenGL:  
```csharp
csglLoad();
```
You can now use OpenGL!

### Cross-platform
CSGL can be ran under Mono, this can be achieved by:
 - Renaming `private const string _lib` in `CSGL.cs`, to for example `libglfw.so.3`.
 - Or making use of [DllMaps](http://www.mono-project.com/docs/advanced/pinvoke/dllmap/).

# GLFW
The GLFW GitGub repository can be found [here](https://github.com/glfw/glfw).  
The GLFW website can be found [here](http://www.glfw.org/).
