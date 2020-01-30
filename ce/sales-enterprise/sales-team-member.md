---
title: "Sales Team Member app for users with Team Member license (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn about the Team Member license enforcement and the new Sales Team Member app."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Sales Team Member app for users with Team Member license

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The new Sales Team Member app is designed for the lightweight sales scenarios where users don't need the full capabilities of an enterprise application. This app is included<!--note from editor: Edit okay?--> with the Team Member license. 

During the early access phase of the Team Member license enforcement, users with the Team Member license can use the designated app modules alongside all existing apps.

The designated app modules are:

- Customer Service Team Member
- Sales Team Member
- Project Resource Hub

At a high level, users with the Team Member license can perform the following tasks in the Sales Team Member app:

-  Customer management: work with accounts and contacts.
-  Lead and opportunity management: see leads or opportunities linked with accounts or contacts, or see other sales-related data.
-  Add activities, such as notes.

For more information about the user rights for the Team Member license, see the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

## Access the Sales Team Member app

Users with the Team Member license can go to home.dynamics.com. They'll see the team member apps they've access to. 

> [!div class="mx-imgBorder"]
> ![Sales Team Member app](media/sales-team-member-app.png "Sales Team Member app")
    
> [!IMPORTANT]
> - During the early access phase, the Sales Team Member app is shown for a user on the Dynamics 365 home page only if they have the Sales Hub installed. If the Sales Team Member app isn't available on the Dynamics 365 home page, they can get it from Microsoft AppSource.
> - To allow your users to use the Sales Team Member app, give them access. The Sales Team Member role gives access to the Sales Team Member app. You can use this role or use custom roles. To learn more, see [Add security roles to the app](/powerapps/maker/model-driven-apps/share-model-driven-app#add-security-roles-to-the-app) in the Power Apps documentation.
    
When users open the app, in the site map, they'll see the entities available in the app. 

> [!div class="mx-imgBorder"]
> ![Site map of the Sales Team Member app](media/sales-team-member-app-site-map.png "Site map of the Sales Team Member app")


<!--note from editor: I'm not sure if the "you" in the procedure above is the same "you" this Important note is addressed to? It doesn't seem to be the same audience.-->

### See also

[Overview of Sales and Sales Hub](overview.md)  