namespace Home_task_1
{
    class ColorLineFinder
    {// Тут краще не атрибутом зробтити, а результатом методу.
        Dictionary<string, int> _colorInfo;
        int[,] _matrix;
        public ColorLineFinder(int[,] matrix)
        {
            _matrix = matrix;
            _colorInfo = new Dictionary<string, int>(){
                {"color", matrix[0, 0]},
                {"rowIndex", 0},
                {"startIndex", 0},
                {"endIndex", 0},
                {"colorLength", 0}
            };
        }
        public void FindLongestColor()
        {
            int longestColor;
            int longerColorlength = 0;
            int colorLength;
            int startIndex;
            int rowLength;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                longestColor = _matrix[i, 0];
                colorLength = 1;
                startIndex = 0;
                rowLength = _matrix.GetLength(1);
                for (int j = 1; j < rowLength; j++)
                {
                    if (_matrix[i, j] == longestColor)
                    {
                        colorLength++;
                    }
                    else
                    {
                        if (colorLength > longerColorlength)
                        {
                            longerColorlength = colorLength;
                            _colorInfo["color"] = longestColor;
                            _colorInfo["startIndex"] = startIndex;
                            _colorInfo["rowIndex"] = i;
                            _colorInfo["endIndex"] = j;
                        }
                        startIndex = j;
                        longestColor = _matrix[i, j];
                        colorLength = 1;
                    }
                    if (colorLength == rowLength)
                    {
                        _colorInfo["color"] = longestColor;
                        _colorInfo["startIndex"] = startIndex;
                        _colorInfo["rowIndex"] = i;
                        _colorInfo["endIndex"] = j;
                        _colorInfo["colorLenght"] = colorLength;
                        return;
                    }
                }
            }
            _colorInfo["colorLenght"] = longerColorlength;
        }
        public override string ToString()
        {
            return "{\n" +
                    "   " + "color:\t" + _colorInfo["color"] + "\n" +
                    "   " + "rowIndex:\t" + _colorInfo["rowIndex"] + "\n" +
                    "   " + "startIndex:\t" + _colorInfo["startIndex"] + "\n" +
                    "   " + "endIndex:\t" + _colorInfo["endIndex"] + "\n" +
                    "   " + "colorLenght:\t" + _colorInfo["colorLenght"] + "\n" +
                    "}";
        }
    }

}
