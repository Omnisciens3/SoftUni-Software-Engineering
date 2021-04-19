using System;
using System.Collections.Generic;
using System.Text;

namespace _05.MilitaryElite
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate @private); //понеже private e ключова думичка в C# използваме @ отпред, за да ескейпнем
    }
}
