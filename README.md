# dnfs - distributed network file search
LAN Search softwares available today scans files on network in real time, thus taking a huge time to show results. This tool is a POC on distributed search, where the different nodes on a network shall store certain information about files available on network and serve the information on request. So while searching for a file, a node will broadcast the search key and wait for response, resulting in way faster search.


#### How its supposed to work?
 - Every node will communicate via socket, and listen on a specific port `12114` by default.
 - Certain nodes called `captains` store indexes of files based on first alphabets.
 - Every node has information on `captains`, if they do not, they'll retrieve it from some other node. Such a node will send out `HELLO WORLD` packet to few online nodes to get `captain` list.
 - Whenever a search is performed, the captains are informed, and captains will returns back possible matches. Then the client node checks which all nodes are online from the list, to form a result.
 
#### FIGURE OUT
 - How will each node share similar burden
 - How will index be improved
 - How will decisions be made
 - When a node or captain goes down, what happens? `BACKUP` options needed.

