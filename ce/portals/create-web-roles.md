# Create web roles for portals

Applies To: Dynamics 365 (online), Dynamics CRM Online

After a contact has been configured to use the portal, it must be given one or more web roles to perform any special actions or access any protected content on the portal. For example, to access a restricted page, the contact must be assigned to a role to which read for that page is restricted to. To publish new content, the contact must be placed in a role which is given content publishing permissions.

To create a web role:

1.  Navigate to **Portals**

<!-- -->

1.  Click **Web Roles**

2.  Click **New**

3.  Specify values for the fields provided

4.  Click **Save**

## Attributes and relationships

The table below explains many of the Web Role attributes used by Dynamics 365 portals.

| Name                     | Description                                                                                                                                                                                                                                     |
|--------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name                     | The descriptive name of the Web Role                                                                                                                                                                                                            |
| Website                  | The associated website                                                                                                                                                                                                                          |
| Description              | An explanation of the Web Role's purpose. Optional.                                                                                                                                                                                             |
| Authenticated Users Role | Boolean. If set to true, this will be the default web role for authenticated users (see below).                                                                                                                                                 
                                                                                                                                                                                                                                                   
  | ![image6](media/image6.png) **Note **                                                                                                                                               |                                  
  |---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|                                
  | Only one Web Role with the Authenticated Users Role attribute set to true should exist for a given website. This will be the default web role for authenticated users that have not been assigned a web role. |                                |
| Anonymous Users Role     | Boolean. If set to true, this will be the default web role for unauthenticated users (see below).                                                                                                                                               
                                                                                                                                                                                                                                                   
  | ![image6](media/image6.png) **Note **                                                                                                                                                                             |    
  |---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
  | Only one Web Role with the Anonymous Users Role attribute set to true should exist for a given website. This will be the default web role for unauthenticated users. **\*\*The Anonymous Users Role will only respect Entity Permissions.** |  |

Now that the Web Role has been created, you will be able to configure it to meet your needs via various permissions, rules, and associations.

## Optional default web role for authenticated users

By enabling the "Authenticated Users Role", it will become the default web role for all users. This role is commonly used to provide a predetermined access for users that are not associated to any other roles. Keep in mind that users can have multiple web roles, but there can only be one Authenticated Users web role for authenticated users.

## Optional default web role for unauthenticated users

The **Anonymous Users Role** is intended to be used with Entity Permissions. It will not respect any other rules or permissions. By enabling the "Anonymous Users Role" it will become the default web role for all users. There can only be one Anonymous Users web role for unauthenticated users.

### See Also

[Control webpage access for portals](webpage-access-control.md)  
[Assign permission set to a web role for portals](assign-permission-web-role.md)  
[Add record-based security by using entity permissions for portals](assign-entity-permissions.md)  

## Enable help for Dynamics 365 portals

To make sure users get the right information when they click the **Help** button, you need to set Dynamics 365 to use custom Help. Go to **Settings** &gt; **Administration**, click **System Settings**, click the **General** tab, and select **Yes** for **Use custom Help for customizable entities**.

## Customize Dynamics 365 portal forms, dashboards, and reports

If you want to customize any of the portal forms, dashboards, or reports, you can find more information about customizing Microsoft Dynamics 365 in the following links:

-   [TechNet: Customize your Dynamics 365 system](https://technet.microsoft.com/library/dn531158.aspx)  

<!-- -->

-   [TechNet: Create and design forms](https://technet.microsoft.com/library/dn531143.aspx)  

-   [TechNet: Create and edit dashboards](https://technet.microsoft.com/library/mt147906.aspx)  

-   [TechNet: Create and edit processes](https://technet.microsoft.com/en-us/library/dn531144.aspx)  

-   [TechNet: Report & Analytics with Dynamics 365](https://technet.microsoft.com/library/dn531183.aspx)  

### See Also

[Configure a Dynamics 365 portal](configure-portal.md)  

## Change the Dynamics 365 instance, audience, or type of portal

After your portal is created and provisioned, you can change the details of your Dynamics 365 instance and portal.

1.  Go to the Dynamics 365 Online Admin center and click the **Applications** tab.

<!-- -->

1.  Select the name of the portal you want to edit and click **Manage**.

2.  Click the **Manage Dynamics 365 Instance** tab. On this page, you can review the Dynamics 365 instance that is currently linked to your portal.

3.  Click the **Update Dynamics 365 Instance** button. In the dialog, use the provided fields to change your Dynamics 365 instance, portal language, or your portal administrator. You can also keep the same Dynamics 365 instance, but change Portal audience or type of portal.

4.  Click the ![Confirm action](media/confirm-action-icon.png "Confirm action") button to confirm your changes.  

![Change Dynamics 365 instance](media/change-dynamics-365-instance.png "Change Dynamics 365 instance")  

### See Also

[Engage with communities by using the community portal](engage-with-communities.md)  
[Configure a Dynamics 365 portal](configure-portal.md)  

