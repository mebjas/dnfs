# dnfs - distributed network file search

#### How its supposed to work?
 - Everynode will communicate via socket, and listen on a specific port `12114` by default.
 - Certain nodes called `captains` store indexes of files based on first alphabets.
 - Eevry node has information on `captains`, if they do not, they'll retrieve it from some node which has it.
 - Whenever a search is performed, the captains are informed, and captains returns back possible matches. Then the client node checks which all nodes are online from the list, to form a result.
 


 #### FIGURE OUT
 - How will each node share similar burden
 - How will index be improved
 - 

