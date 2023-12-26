using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Arquitect : IWorkTeamActivities, IDesignActivities, IDevelopActivities, ITestActivities
    {
        void IWorkTeamActivities.Comunicate()
        {
            throw new NotImplementedException();
        }

        void IDesignActivities.Design()
        {
            throw new NotImplementedException();
        }

        void IDevelopActivities.Develop()
        {
            throw new NotImplementedException();
        }

        void IWorkTeamActivities.Plan()
        {
            throw new NotImplementedException();
        }

        void ITestActivities.Test()
        {
            throw new NotImplementedException();
        }
    }
}