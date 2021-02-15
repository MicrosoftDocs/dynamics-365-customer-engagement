---
title: "View conversation and session form in model-driven apps apps | MicrosoftDocs"
description: "Learn about the omnichannel conversations and session forms that users (agents and supervisors) who are not part of can Omnichannel for Customer Service can under the Activities in model-driven apps apps."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/27/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# View omnichannel conversations and omnichannel session in model-driven apps

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

In your organization, some agents might work in a contact center that uses Omnichannel for Customer Service, whereas other agents work in a different contact center that uses Microsoft model-driven apps, such as Omnichannel for Customer Service app. In this case, if you're an agent who works in the ,model-driven 365 apps, and you must analyze a conversation request from Omnichannel for Customer Service, you can find the information through **activities** in model-driven apps.

You can find the following activity types in model-driven apps apps:

 - Conversation form

 - Omnichannel session

### Conversation form

The conversation form displays information about a conversation request.

| Section         | Field            |
|-----------------|-------------------|
| Details         | <ul> <li>Title</li> <li>Customer</li> <li>Live work stream</li> <li>Active agent</li>  <li>Activity status</li> <li>Status reason</li> <li>Status updated on</li> <li>Regarding</li> <li>Queue</li> </ul> |
| History         | <ul> <li>Created on</li> <li>Closed on</li> <li>Modified on</li> <li>Transfer count</li> <li>Escalation count</li> </ul> |
| Session details | <ul> <li>Subject</li> <li>Date created</li> </ul> |

> [!div class=mx-imgBorder]
> ![omnichannel conversation form](../../customer-service/media/oc-crm-conversation-form.png "omnichannel conversation form")  

### Session form

The omnichannel session displays information about a conversation request.

| Section | Field           |
|---------|-----------------|
| Header  | <ul> <li>Priority</li> <li>Due Date</li> <li>Activity Status</li> </ul> |
| General | <ul> <li>Subject</li> <li>Owner</li> <li>Regarding</li> <li>Name</li> <li>Created on</li> </ul>|
| Notes   | <ul> <li>Notes</li> </ul> |

> [!div class=mx-imgBorder]
> ![omnichannel session form](../../customer-service/media/oc-crm-omni-channel-session-form.png "Omnichannel session form") 

> [!div class="nextstepaction"]
> [Next topic: View customer summary for an incoming conversation request](view-customer-summary-incoming-conversation-request.md)

## See also

- [View customer summary and know everything about customers](customer-summary.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]