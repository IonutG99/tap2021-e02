# Evaluarea nr. 2 pentru cursul Tehnici Avansate de Programare #

## SOLID ##

###Single Responsibility
Principiul ne spune ca o clasa trebuie sa aiba o singura responsabilitate si in plus ea trebuie sa aiba un singur motiv pentru a se schimba.


###Open for Extension, Closed for Modification
Clasele trebuie sa fie usor de extins dar greu de modificat, in modul acesta, ne vom opri din a modifica codul existent cauzand eventuale noi bug-uri.

###Liskov Substitution
Principiul sustine ca daca clasa A este o subclasa a clasei B, atunci ar trebui sa putem sa substituim B cu A fara a perturba comportamentul programului nostru.

###Interface Segregation
Principiul spune ca interfetele mai mari ar trebui impartite in altele mai mici.
Procedand astfel, ne putem asigura ca implementarea claselor trebuie sa fie axata doar pe metodele care ne intereseaza.

###Dependency Inversion
Modulele unui sistem software trebuie sa depinda de reprezentari abstracte si nu de implementari concrete.