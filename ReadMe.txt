First of all, the code is not being compiled since it's the only one part of a solution dependant of another components.
The code is for finding errors of filled bulletin for voting. Bulletin is a list of questions. In this case there are 3 types of questions:
Simple, Qumulative and Separate.
Start point is Validator class:
1. A tree is build on based bulletin and the tree's nodes are rules wich should be fulfilled (property IsFulfilled) to consider the bulletin as valid. In case of violating at least one rule the bulletin is acknowledged as invalid and a user should get the reason
(from method GetErrorText())
2. Each rule has corresponding interface elements - class DocField. DependsOn property extracts such ui components. 
Property DependantRulesDependOn extracts all ui components related to the same rule;
3. As a result, there is an array of ui elements with text and error status in case of existing errors.
