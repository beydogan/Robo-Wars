The aim of the project is to develop a paintball game played among robots.  
The characteristics of the game are explained below. 
General Information 
There are 6 types of robots with different features in the game. Two teams consisting of three robots play 
the game. Team A is managed by a human player and team B is managed by the computer. The aim is to 
hit the other team with a paintball.  
Features of the Robots 
Each robot has different throwing and protecting skills in the game. 
Type No Robot Type  Throw Capacity Protection Capacity Price  
1 C64 400 350 600 
2 C++ 450 500 800 
3 ZX Manga 600 550 1000 
4 XR21 700 700 1300 
5 Great Protector  600 800 1700 
6 Great Thrower  800 600 1900 
Two types of robots have extra features. Robot type 5 increases the protection capacity of the other robots 
in its team by 50%. Robot type 6 increases the throwing capacity of the other robots in its team by 50%. 
Stages of the Game 
1. Input the amount of credits team A has. Default value is 6000. 
2. Teams choose the types of robots. Teams can have the same type of robots. Computer chooses its robots
randomly. 
3. Teams buy throw energy and protection energy with the rest of their credits. Each unit of energy is 1  
    credit. 
4. Teams distribute their energy among their robots. Team B sets its robot’s energy randomly in the range 
of a lower limit and robot’s capacity:  
• in the first round, lower limit is 250  
• in the second round, lower limit is 300 
• in the third round, lower limit is 350 
     
5. Choosing Strategy: There are three sub steps in this stage. Firstly, the robots of the teams appear on the 
screen. Then, team A inputs the target of its robots. Finally, team B chooses its targets randomly. 
6. Game Play: Game is played simultaneously for each team, lasting only a moment. If a robot's protection 
energy is greater or equal to the sum of the throw energy of the opponent robots targeting it, then the 
robot is considered not hit. Statistics are given at the end of each round: 
• information about robots which are hit and teams’ credits 
• types of robots in that round 
• identical types of robots in both teams  
• the robot which has the highest throw energy   
• the robot which has the highest protection energy 7. If all robots in a team are hit, the other team wins the game with full victory. If at least one robot is left 
in each team, a new round begins. There are maximum 3 rounds. At the end of the 3 rounds, the team 
with the highest credits including the prices of the robots wins the game with half victory. 
    Operations at the beginning of a new round;  
• all energy of the alive robots runs out. 
• teams earn credits equal to the sum of the price of the opponent robots which were hit in 
previous round as prize.  
• extra 4000 credits are given to team A to buy energy, also new robots if necessary.  
Each team must have 3 robots in each round.  
Sample Screen Displays 
====== Game Round 1 ====== 
--- Stage 1: Input team A's credits 
A: 6000     
--- Stage 2: Choose robots 
Robot 1: 1      
Robot 2: 1 
Robot 3: 6 
--- Stage 3: Buy Energy 
Remaining credits= 2900 
Throw energy: 1800 
Protection energy: 1000 
--- Stage 4: Share Energy 
Robot 1 throw energy: 600 
Robot 2 throw energy: 600 
Robot 3 throw energy: 600 
Robot 1 protection energy: 250 
Robot 2 protection energy: 250 
Robot 3 protection energy: 500 
--- Stage 5: Choose Strategy 
AR1:1     -     BR1:3     
AR2:1     -     BR2:5     
AR3:6     -     BR3:1     
1->1      -     1->3        
2->2      -     2->3        
3->2      -     3->3        
BR1-throw: 505   BR1-prot.: 825 
BR2-throw: 453   BR2-prot.: 800 
BR3-throw: 251   BR3-prot.: 250 
--- Stage 6: Results 
AR1:1     -     BR1:3     
AR2:1     -     BR2:-     
AR3:-     -     BR3:1   
Team A Credits: 1800 
Team B Credits: 1900 
type of robots: 1 3 5 6 
identical types in both teams: 1 
highest throw: AR1 AR2 AR3 
highest prot.: BR1 
====== Game Round 2 ====== 
--- Stage 1: Credits of teams 
A: 5800      B: 1900 
--- Stage 2: Choose robots 
Robot 3: 4 
--- Stage 3: Buy Energy 
Remaining credits= 4500 
Throw energy: 1500 
Protection energy: 1400 
--- Stage 4: Share Energy 
Robot 1 throw energy: 400 
Robot 2 throw energy: 400 
Robot 3 throw energy: 700 
Robot 1 protection energy: 350 
Robot 2 protection energy: 350 
Robot 3 protection energy: 700 
--- Stage 5: Choose Strategy 
AR1:1     -     BR1:3     
AR2:1     -     BR2:2     
AR3:4     -     BR3:1     
1->2      -     1->3        
2->3      -     2->2        
3->1      -     3->3       
BR1-throw: 301   BR1-prot.: 523 
BR2-throw: 434   BR2-prot.: 375 
BR3-throw: 400   BR3-prot.: 340 
--- Stage 6: Results 
AR1:1     -     BR1:-     
AR2:-     -     BR2:-     
AR3:-     -     BR3:-   
Team A Credits: 1600 
Team B Credits: 1900 
type of robots: 1 2 3 4 
identical types in both teams: 1 
highest throw: AR3 
highest prot.: AR3 
Team A wins the game with full victory
Suggested Weekly Program 
1. Creating the necessary variables, menu, screen display 
2. Inputs, choosing robots, energy operations, strategy, results stage 
3. Remaining part of results stage, other rounds 