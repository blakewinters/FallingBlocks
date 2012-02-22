using System;

namespace FallingBlocks {
#if WINDOWS || XBOX
    static class Program {
        static void Main(string[] args) {
            using (FallingBlocks game = new FallingBlocks()) {
                game.Run();
            }
        }
    }
#endif
}

