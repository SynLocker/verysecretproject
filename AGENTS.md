Questo repository contiene un progetto Unity per un semplice gioco di slot machine 2D.
La cartella `Assets` include i sorgenti e gli asset, mentre `ProjectSettings` 
contiene le impostazioni del progetto Unity.

Le classi principali sono:
- `Assets/AchievementManager.cs`: definisce l'enum `SymbolType` per i simboli (Shoes, Jewels, Coconuts, Stars, Hearts, Diamonds) e la lista di achievements. Ogni volta che il giocatore ottiene una combinazione specifica, si sblocca un nuovo simbolo. Ad esempio l'achievement "First Triple" sblocca i Coconuts.
- `Assets/SlotMachine.cs`: gestisce la logica di gioco, avviando la rotazione delle ruote e controllando i risultati. Chiama `AchievementManager` per verificare se un achievement è stato sbloccato.
- `Assets/SlotWheel.cs`: crea i simboli disponibili in base a quelli sbloccati e gestisce la rotazione e l'arresto di ciascuna ruota.

In sintesi, il progetto è un gioco di slot machine in cui girando le ruote si possono sbloccare nuovi simboli grazie al sistema di achievement.
