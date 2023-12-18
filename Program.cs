using Design_patterns_in_C_.Builder;
using Design_patterns_in_C_.Singleton;
using Design_patterns_in_C_.Singleton.Theoretical_example;

// Singleton
//MySingleton mySingleton = MySingleton.GetInstance();

// Builder
IRobotBuilder robotBuilder = new RobotBuilder();
RobotDirector robotDirector = new RobotDirector(robotBuilder);
robotDirector.ConstructRobot();
Robot robot = robotBuilder.GetRobot();
robot.DisplayRobotInfo();