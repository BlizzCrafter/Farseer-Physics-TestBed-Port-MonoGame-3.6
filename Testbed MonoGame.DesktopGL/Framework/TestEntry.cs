using System;

namespace Testbed_MonoGame.DesktopGL.Framework
{
    public struct TestEntry
    {
        public Func<Test> CreateTest;
        public string Name;
    }
}