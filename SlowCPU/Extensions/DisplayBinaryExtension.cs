namespace SlowCPU.Extensions {
    public static class DisplayBinaryExtension {

        public static string ToDisplayBinary(this int i) {
            return RecursiveBinaryDisplay(i).ToString();
        }

        private static int RecursiveBinaryDisplay(int i) {
            return i == 0 || i == 1
                ? i
                : i % 2 + 10 * RecursiveBinaryDisplay(i / 2);
        }
    }
}