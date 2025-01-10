# Übungsaufgabe: Mario-more

### Aufgabe:

Zu Beginn von Level 1-1 in Nintendo’s Super Mario Brothers muss Mario über benachbarte Pyramiden aus Blöcken springen, wie unten gezeigt.

![Screenshot von Mario, der über benachbarte Pyramiden springt](https://i.ibb.co/whwQQph/pyramids.png)

Erstelle eine Konsolenanwendung in C#, welche diese Pyramide nachbildet. Verwende dabei Hashes (#) als Bausteine, wie in folgendem Beispiel dargestellt:

```
   #  #
  ##  ##
 ###  ###
####  ####
```

Der Benutzer soll die Möglichkeit haben, die Höhe der Pyramiden selbst zu bestimmen. Es soll eine positive Zahl zwischen 1 und 8 (einschließlich) eingegeben werden.

## Beispiele

So könnte die Ausgabe aussehen, wenn der Benutzer die Zahl 8 eingibt:

```
$ ./mario
Height: 8
       #  #
      ##  ##
     ###  ###
    ####  ####
   #####  #####
  ######  ######
 #######  #######
########  ########
```

So könnte die Ausgabe aussehen, wenn der Benutzer die Zahl 4 eingibt:

```
$ ./mario
Height: 4
   #  #
  ##  ##
 ###  ###
####  ####
```

So könnte die Ausgabe aussehen, wenn der Benutzer die Zahl 2 eingibt:

```
$ ./mario
Height: 2
 #  #
##  ##
```

Und so könnte die Ausgabe aussehen, wenn der Benutzer die Zahl 1 eingibt:

```
$ ./mario
Height: 1
#  #
```

Wenn der Benutzer keine positive Zahl zwischen 1 und 8 (einschließlich) eingibt, dann soll das Programm solange nach einer Eingabe fragen, bis dieser eine Gültige Zahl angibt:

```
$ ./mario
Height: -1
Height: 0
Height: 42
Height: 50
Height: 4
   #  #
  ##  ##
 ###  ###
####  ####
```

Der Abstand zwischen beiden Pyramiden hat die Breite von zwei "Hashes" unabhöngig der Höhe der Pyramide.

## Deinen Code testen:

Funktioniert dein Code wie beaabsichtigt bei folgender Eingabe?

- -1 (oder andere negative Zahlen)?
- 0?
- 1 bis 8?
- 9 oder andere positive Zahlen?
- Buchstaben oder Wörter?
- Keine Eingabe oder nur "Enter"?
