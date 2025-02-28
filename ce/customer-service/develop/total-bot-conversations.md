---
title: Total bot conversations
description: Learn how total bot coversations are calculated.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/19/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/25/2025
---

# Total bot conversations

_**Applies to**: Omnichannel Historical Bot dashboard, Omnichannel Real-time Bot dashboard_

The total number of conversations that have taken place during the selected period of time, across all statuses (active conversations and closed conversations) taking place with Voice/IVR or chat/digital bot.

Bot deflected conversations + Bot escalated conversations = Total bot conversations

## Query

This section describes the query that is used to calculate the total bot conversations in Power BI and Dataverse.

### [Historical analytics](#tab/historicalpage)

```dax

conversations_FactSession=CALCULATE(DISTINCTCOUNT(FactSession[ConversationId_FS]))
 
Dax -> Distinct Count of FactSession[ConversationId_FS]

```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where ConversationId = msdyn_ocsession.msdyn_liveworkitemid
Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'
Exclude sessions from 'Entity Records' channel and SMS filter

```

 | Attribute                     | Definition                                                                                                                                                                                                 |
|-------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ConversationId                | The unique identifier of the conversation.                                                                                                                                                                 |
|msdyn_eventreason| Reason for session event. Learn more in [msdyn_eventreason](/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventreason) |
|msdyn_eventtype|Type of session event e.g. accept, reject etc. Learn more in [msdyn_eventtype](/dynamics365/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventtype)|

### [Real-time analytics](#tab/realtimepage)

Use this query for realtime analytics.

```dax

conversations_FactSession=CALCULATE(DISTINCTCOUNT(FactSession[ConversationId_FS]))
 
Dax -> Distinct Count of FactSession[ConversationId_FS]

```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where ConversationId = msdyn_ocsession.msdyn_liveworkitemid
Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'
Exclude sessions from 'Entity Records' channel and SMS filter

```
---

## Related metrics

- **Bot deflected conversations**: Total number of conversations where bot was involved and the conversation remained contained within bot without service representative escalation. ​

- **Bot escalated conversations**: Total number of conversations where bot was initially involved and then the issue is escalated to the service representative for support. 
