using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_practice
{ 
/// <summary>
/// Remake of Java Quiz System
/// Meant to be abstract menus - can be read from console, gui, etc.
/// </summary>
class Menu
{
    protected String _author;
    protected String _time;
    protected String _content;
    protected List<Menu> _children;
    protected Menu _parent;
}
}