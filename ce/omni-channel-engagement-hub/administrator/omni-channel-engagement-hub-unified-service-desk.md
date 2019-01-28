---
title: "Omni-channel Engagement Hub on Unified Service Desk | MicrosoftDocs"
description: "Omni-channel Engagement Hub solution is an application that you need to install on Unified Service Desk client application."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: C6488858-82BF-450A-90F4-83FB2C41718C
ms.custom: 
---

# Omni-channel Engagement Hub on Unified Service Desk

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Unified Service Desk for Dynamics 365 Customer Engagement apps is a client application. You need to install the Unified Service Desk client application on every agent desktop to use Omni-channel Engagement Hub. 
 
Omni-channel Engagement Hub is packaged as solution that you need to deploy on a Dynamics 365 for Customer Service Hub application instance. Use the Microsoft Dynamics 365 Package Deployer to deploy the Omni-channel Engagement Hub solution on the Customer Service Hub application instance.

## Download the Package Deployer

Download the [Microsoft Dynamics 365 Package Deployer](http://go.microsoft.com/fwlink/p/?LinkID=872261) and extract the contents in to a folder.

## Download Unified Service Desk client application

To download the Unified Service Desk client application, you must join the Omni-channel Engagement Hub - Preview program.

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

## Install Unified Service Desk client

To learn how to install Unified Serivce Desk, see [Install Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/install-upgrade-unified-service-desk-client).

Make sure you computer meets all requirements before you install the Unified Service Desk client application. More information: [Unified Service Desk system requirements](/dynamics365/customer-engagement/unified-service-desk/admin/unified-service-desk-system-requirements)

## Configure Unified Service Desk recommended settings for Internet Explorer

The Internet Explorer process is used to host web applications in Unified Service Desk. When you use Omni-channel Engagement Hub on Unified Service Desk client application, certain settings are recommended for Internt Explorer for optimal performance.

To know more information about manually configuring the settings of Internet Explorer, see [Internet Explorer setting guidelines](/dynamics365/customer-engagement/unified-service-desk/admin/internet-explorer-settings-bpa).

Configure the Internet Explorer Settings on the every client desktops for the following areas :

 - Enable popups for trusted sources 
 - Enable Protected Mode option
 - Tab Process Growth (TabProcGrowth) registry key
 - Tab Shutdown Delay (TabShutdownDelay) registry key
 - Enable Automatic Crash Recovery option

## Enable popups for trusted sources
 1. Open Internet Explorer.

 2.	Select **Tools** > **Internet Options** > **Privacy**.

 3.	In the **Turn on pop-up Blocker** section, select **Settings**.

 4.	In the **Address of website to allow** field, specify one URL and select **Add**. <br>
    Add the following URLs:<br>
  - *.core.windows.net
  - *.microsoftonline.com
  - *.office.com
  - *.powerbi.com
  - *.dynamics.com
  - *.crmdynint.com
  - *.azureedge.net
  - *.azurewebsites.net

  5. Select **Close**, and then select **OK**.

Based on your organization requirements, you can add any other URLs in allowed sites along with the above-mentioned URLs.

To configure the **Enable Protected Mode** option, **TabProcGrowth** (Tab Process Growth), **TabShutdownDelay** (Tab Shutdown Delay) registry key, and **Enable Automatic Crash Recovery** option, see [Internet Explorer setting guidelines](/dynamics365/customer-engagement/unified-service-desk/admin/internet-explorer-settings-bpa).


## See also

- [Configure agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md)
- [Customize Customer summary form](customize-customer-360-page.md)
- [Customize the conversation form](customize-conversation-form.md)
- [Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)