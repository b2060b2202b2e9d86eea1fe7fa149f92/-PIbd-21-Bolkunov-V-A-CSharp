using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
    public class PierOverflowException : Exception
    {
        public PierOverflowException() : base("На парковке нет свободных мест")
        { }
    }

    public class PierShipNotFoundException : Exception
    {
        public PierShipNotFoundException(int place) : base($"Корабль на месте {place} не найден")
        { }
    }

    public class PierShipCannotBeAddedException : Exception
    {
        public PierShipCannotBeAddedException(string pier) : base($"Корабль не может быть добавлен на причал {pier}")
        { }
    }

    public class FileFormatException : Exception
    {
        public FileFormatException(string fileName) : base($"Файл \"{fileName}\" неверно отформатирован")
        { }
    }

    public class PierShipAlreadyExistsException : Exception
    {
        public PierShipAlreadyExistsException() : base("На причале уже существует такой корабль")
        { }
    }
}
