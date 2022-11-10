---
title: "Configure user roles to access analytics reports  | MicrosoftDocs"
description: "Use this article to learn how to configure report access to security roles."
ms.date: 11/11/2022
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Configure user roles to access analytics reports

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/) and select your environment.

1. In the **Access** section, under **Security roles**, select **See all**.

1. Select a role, and then select **Edit**. 
    If you want to create a new role, select **New role**, and in the new **New Security role** dialog, enter a name in the **Role Name** field of the **Details** tab.

1. On the **Custom Entities** tab, grant **Read** privileges to the following features:
    - **Omnichannel historical analytics**  
    - **Omnichannel Realtime analytics**   
    - **Customer service historical analytics** 
    - **Knowledge analytics** 

1. Select **Save and close**. 

1. Select the role that you just created or updated, and then select **Add people** to add your supervisors to the role.
