using ChromaticCanvas.ApplicationLogic.Abstractions;
using ChromaticCanvas.ApplicationLogic.DataModel;
using System;
using System.Linq;

namespace ChromaticCanvas.DataAccess
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {

        public MemberRepository(ChromaticCanvasDbContext dbContext) : base(dbContext)
        {
        }

        public Member GetMemberById(Guid userID)
        {
            return dbContext.Members
                .Where(member => member.ID == userID).SingleOrDefault();
        }
    }
}
