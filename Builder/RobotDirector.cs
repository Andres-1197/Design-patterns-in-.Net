using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.Builder
{
    //Director
    public class RobotDirector { 
        
        private IRobotBuilder _robotBuilder;

        public RobotDirector (IRobotBuilder robotBuilder) {

            _robotBuilder = robotBuilder;
        }

        public void ConstructRobot()
        {
            _robotBuilder.BuildArms("Round");
            _robotBuilder.BuildBody("Metal");
            _robotBuilder.BuildHead("Claws");
            _robotBuilder.BuildLegs("Wheels");
        }
    }
}
