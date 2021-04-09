---
title: "Role persona mapping | MicrosoftDocs"
description: "Information about how security roles can be mapped to personas."
author: meghanalanka
ms.author: v-mlanka
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Add security roles for admins and users

You can use the Microsoft Dynamics 365 admin center to assign user security roles. Persona mapping can be found in the Omnichannel Admin Center (preview) or Customer Service Hub in the **User attributes** section. For the assigned security user roles to be functional, perform the following steps.

1. Map roles to personas
2. Enable access to applications
3. Enable access to forms and dashboards

## Map roles to personas

Default mapping will automatically assign primary roles depending on the Dynamics services enabled for your environment. For an environment with Customer Service Enterprise, the default mapping includes customer service representative and CSR manager. For an environment with Omnichannel for Customer Service, the three primary OC security roles are mapped to personas. If both services are enabled, both sets of default mappings are included.  

| Service | Admin persona default mapping | Supervisor persona default mapping | Agent persona default mapping |
| ------------- | ---------------- | ------------------- | --------------- |
| Customer Service Enterprise | CSR Manager | CSR Manager | Customer service representative |
| Omnichannel for Customer Service | OC Admin | OC Supervisor | OC Agent |  
| Customer Service Enterprise + OC for Customer Service | CSR Manager OC Admin | CSR Manager OC Supervisor | Customer service representative OC Agent |   

### Manage personas

To customize the role to persona mapping, perform the following steps. 

1. Sign in to **Omnichannel admin centre**.

or

Sign in to **Customer Service Hub** and change to the **Service Management** work area. 

2. Select **User attributes** from the **Unified routing** menu.

3. Select **Manage** for **Role persona mapping**.

4. Click on any one of the personas to add or remove security roles. 

5. Check or uncheck the boxes next to the security roles within the configuration window. 

6. Select **Save and Close**.

You can now see the new roles populated in the personas. 

## Enable access to applications

Users with security roles mapped to Personas do not get automatic access to associated dashboards or applications. Access needs to be provided by administrators.  

Perform the following steps to ensure that access and privileges are provided to users. 

1. Create the required user role. For more information on how to create and assign user security roles. 

2. Add and edit user permissions and privileges as required. 

3. Sign in to Dynamics 365. 

4. Click on the ellipsis in the application tile. 

5. Select **Manage roles**. 

6. In the dialog box that appears, select the custom role that you want to grant permission to and select **Save**. 

> [!NOTE] 
> Custom security roles must have correct access levels for the appropriate records to ensure persona mapping will work.   

## Enable access to forms and dashboards

To enable access to a form or dashboard, perform the following steps. 

1. Sign in to Dynamics 365 Omnichannel admin centre. 

2. Go to **Advanced Settings* > **Settings** and **Customizations **. 

3. Select **Customize the system**. 

4. From the **Solution Default Solution** list, select **Entities** > **Characteristics** > **Forms**. 

5. Open and active form and select **Enable security roles**. 

6. Select the role that you want to provide access to and select **OK**. 

