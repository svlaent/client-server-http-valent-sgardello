# Corso protocolli di comunicazione IoT - Protocollo MQTT

Repository GitHub Simone Valent - Fabio Sgardello AMAR 2022-23
## Payload
Tipo di payload: Json

esempio:
```json
{
    "Value": 77,
    "Type": "Level"
}
```

## Sicurezza
### Autenticazione
Al fine di limitare accessi indesiderati ai messaggi è possibile implementare un sistema di autenticazione. Nel caso fossero supportati possono essere utilizzati dei certificati per gestire l'autenticazione. Un'altra via per gestire l'autenticazione può essere mediante l'uso di una coppia di credenziali classiche (username;password).

Se per qualsiasi motivo non è possibile implementare alcun tipo di autenticazione, è possibile criptare il payload mediante un'algoritmo, ma si tratta dell'utlima soluzione attuabile.

### Autorizzazione
Una buona pratica da implementare potrebbe essere quella di permettere al client di pubblicare solamente nella sua area di competenza (es. sensore con id 1 potrà pubblicare solo nel topic `silos/1/#`)
