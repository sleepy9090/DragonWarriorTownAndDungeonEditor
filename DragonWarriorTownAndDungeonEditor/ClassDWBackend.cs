using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Shawn M. Crawford - [sleepy9090] - 2017
namespace DragonWarriorTownAndDungeonEditor
{
    class ClassDWBackend
    {
        string path;

        public ClassDWBackend(string gamePath)
        {
            path = gamePath;
        }

        public string getTantegelCastleThroneRoomData() {
            return getHexStringFromFile(0x412, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setTantegelCastleThroneRoomData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x412, StringToByteArray(roomData));
        }

        public string getTantegelCastleBasementSunlightShrineData()
        {
            return getHexStringFromFile(0xD34, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setTantegelCastleBasementSunlightShrineData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xD35, StringToByteArray(roomData));
        }

        public string getTantegelCastleData()
        {
            return getHexStringFromFile(0x250, 0x1C2); // 30x30 grid = 900 nibbles = 450 (1C2h) bytes
        }

        public bool setTantegelCastleData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x250, StringToByteArray(roomData));
        }

        public string getRimuldarData()
        {
            return getHexStringFromFile(0xB72, 0x1C2); // 30x30 grid = 900 nibbles = 450 (1C2h) bytes
        }

        public bool setRimuldarData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xB72, StringToByteArray(roomData));
        }

        public string getCantlinData()
        {
            return getHexStringFromFile(0x8E8, 0x1C2); // 30x30 grid = 900 nibbles = 450 (1C2h) bytes
        }

        public bool setCantlinData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x8E8, StringToByteArray(roomData));
        }

        public string getBrecconaryData()
        {
            return getHexStringFromFile(0x726, 0x1C2); // 30x30 grid = 900 nibbles = 450 (1C2h) bytes
        }

        public bool setBrecconaryData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x726, StringToByteArray(roomData));
        }

        public string getKolData()
        {
            return getHexStringFromFile(0x606, 0x120); // 24x24 grid = 576 nibbles = 288 (120h) bytes
        }

        public bool setKolData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x606, StringToByteArray(roomData));
        }

        public string getSwampCaveData()
        {
            return getHexStringFromFile(0xF8C, 0x5A); // 6x30 grid = 180 nibbles = 90 (5Ah) bytes
        }

        public bool setSwampCaveData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xF8C, StringToByteArray(roomData));
        }

        public string getRainShrineData()
        {
            return getHexStringFromFile(0xD66, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setRainShrineData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xD66, StringToByteArray(roomData));
        }

        public string getRainbowShrineData()
        {
            return getHexStringFromFile(0xD98, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setRainbowShrineData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xD98, StringToByteArray(roomData));
        }

        public string getErdricksCaveB1Data()
        {
            return getHexStringFromFile(0x12C0, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setErdricksCaveB1Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x12C0, StringToByteArray(roomData));
        }

        public string getErdricksCaveB2Data()
        {
            return getHexStringFromFile(0x12F2, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setErdricksCaveB2Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x12F2, StringToByteArray(roomData));
        }

        public string getGarinhamsGraveB1Data()
        {
            return getHexStringFromFile(0x10AA, 0xC8); // 20x20 grid = 400 nibbles = 200 (C8h) bytes
        }

        public bool setGarinhamsGraveB1Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x10AA, StringToByteArray(roomData));
        }

        public string getGarinhamsGraveB2Data()
        {
            return getHexStringFromFile(0x126C, 0x54); // 14x12 grid = 168 nibbles = 84 (54h) bytes
        }

        public bool setGarinhamsGraveB2Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x126C, StringToByteArray(roomData));
        }

        public string getGarinhamsGraveB3Data()
        {
            return getHexStringFromFile(0x1172, 0xC8); // 20x20 grid = 400 nibbles = 200 (C8h) bytes
        }

        public bool setGarinhamsGraveB3Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x1172, StringToByteArray(roomData));
        }

        public string getGarinhamsGraveB4Data()
        {
            return getHexStringFromFile(0x123A, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setGarinhamsGraveB4Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x123A, StringToByteArray(roomData));
        }

        public string getGarinhamData()
        {
            return getHexStringFromFile(0xAAA, 0xC8); // 20x20 grid = 400 nibbles = 200 (C8h) bytes
        }

        public bool setGarinhamData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xAAA, StringToByteArray(roomData));
        }

        public string getCharlockCastleB1Data()
        {
            return getHexStringFromFile(0xDCA, 0xC8); // 20x20 grid = 400 nibbles = 200 (C8h) bytes
        }

        public bool setCharlockCastleB1Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xDCA, StringToByteArray(roomData));
        }

        public string getCharlockCastleB2Data()
        {
            return getHexStringFromFile(0xE92, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setCharlockCastleB2Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xE92, StringToByteArray(roomData));
        }

        public string getCharlockCastleB3Data()
        {
            return getHexStringFromFile(0xEC4, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setCharlockCastleB3Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xEC4, StringToByteArray(roomData));
        }

        public string getCharlockCastleB4Data()
        {
            return getHexStringFromFile(0xEF6, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setCharlockCastleB4Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xEF6, StringToByteArray(roomData));
        }

        public string getCharlockCastleB5Data()
        {
            return getHexStringFromFile(0xF28, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setCharlockCastleB5Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xF28, StringToByteArray(roomData));
        }

        public string getCharlockCastleB6Data()
        {
            return getHexStringFromFile(0xF5A, 0x32); // 10x10 grid = 100 nibbles = 50 (32h) bytes
        }

        public bool setCharlockCastleB6Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xF5A, StringToByteArray(roomData));
        }

        public string getCharlockCastleB7Data()
        {
            return getHexStringFromFile(0x444, 0x1C2); // 30x30 grid = 900 nibbles = 450 (1C2h) bytes
        }

        public bool setCharlockCastleB7Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x444, StringToByteArray(roomData));
        }

        public string getCharlockCastleF1Data()
        {
            return getHexStringFromFile(0xC0, 0xC8); // 20x20 grid = 400 nibbles = 200 (C8h) bytes
        }

        public bool setCharlockCastleF1Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xC0, StringToByteArray(roomData));
        }

        public string getHauksnessData()
        {
            return getHexStringFromFile(0x188, 0xC8); // 20x20 grid = 400 nibbles = 200 (C8h) bytes
        }

        public bool setHauksnessData(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x188, StringToByteArray(roomData));
        }

        public string getRockMountainB1Data()
        {
            return getHexStringFromFile(0xFE6, 0x62); // 14x14 grid = 196 nibbles = 98 (62h) bytes
        }

        public bool setRockMountainB1Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0xFE6, StringToByteArray(roomData));
        }

        public string getRockMountainB2Data()
        {
            return getHexStringFromFile(0x1048, 0x62); // 14x12 grid = 168 nibbles = 84 (54h) bytes
        }

        public bool setRockMountainB2Data(string roomData)
        {
            return writeByteArrayToFile(this.path, 0x1048, StringToByteArray(roomData));
        }

        #region common methods
        private static string convertAsciiToHex(String asciiString)
        {
            char[] charValues = asciiString.ToCharArray();
            string hexValue = "";
            foreach (char c in charValues)
            {
                int value = Convert.ToInt32(c);
                hexValue += String.Format("{0:X}", value);
            }
            return hexValue;
        }

        private static string convertHexToAscii(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private string getHexStringFromFile(int startPoint, int length)
        {
            string hexString = "";
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {
                long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

                for (int x = 0; x < length; x++)
                {
                    hexString += fileStream.ReadByte().ToString("X2");
                }

            }

            return hexString;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private bool writeByteArrayToFile(string fileName, int startPoint, byte[] byteArray)
        {
            bool result = false;
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = startPoint;
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error writing file: {0}", ex);
                result = false;
            }

            return result;
        }
        #endregion
    }
}
