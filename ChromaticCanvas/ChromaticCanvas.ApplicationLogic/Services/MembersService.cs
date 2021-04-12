using ChromaticCanvas.ApplicationLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class MembersService
    {
        private IMemberRepository memberRepository;

        public MembersService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }
    }
}
