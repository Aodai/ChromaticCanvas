using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using ChromaticCanvas.ApplicationLogic.Exceptions;
using System;

namespace ChromaticCanvas.ApplicationLogic.Services
{
    public class MembersService
    {
        private IMemberRepository memberRepository;

        public MembersService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public Member GetMemberById(string id)
        {
            Guid userGuid = Guid.Empty;
            if (!Guid.TryParse(id, out userGuid))
                throw new Exception("Invalid Guid format");

            var member = memberRepository.GetMemberById(userGuid);
            if (member == null)
                throw new EntityNotFoundException(userGuid);

            return member;
        }
    }
}
