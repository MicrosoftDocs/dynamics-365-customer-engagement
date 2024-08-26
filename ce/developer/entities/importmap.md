---
title: "Data Map (ImportMap) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Data Map (ImportMap) table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Data Map (ImportMap) table/entity reference (Microsoft Dynamics 365)

Data map used in import.

> [!NOTE]
> The Microsoft Dynamics 365 Data Map (ImportMap) table extends the [Microsoft Dataverse Data Map (ImportMap) table](/power-apps/developer/data-platform/reference/entities/importmap).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_TargetEntity"></a> TargetEntity

Changes from [TargetEntity (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/importmap#BKMK_TargetEntity)

#### TargetEntity Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|16|**AccountLeads**|
|17|**ContactInvoices**|
|18|**ContactQuotes**|
|19|**ContactOrders**|
|20|**Service Contract Contact**|
|21|**ProductSalesLiterature**|
|22|**ContactLeads**|
|24|**LeadCompetitors**|
|25|**OpportunityCompetitors**|
|26|**CompetitorSalesLiterature**|
|27|**LeadProduct**|
|32|**Sales Process Instance**|
|112|**Case**|
|113|**Child Incident Count**|
|123|**Competitor**|
|952|**Phone To Case Process**|
|953|**Opportunity Sales Process**|
|954|**Lead To Opportunity Sales Process**|
|1004|**Competitor Address**|
|1006|**Competitor Product**|
|1010|**Contract**|
|1011|**Contract Line**|
|1013|**Discount**|
|1017|**Lead Address**|
|1022|**Price List**|
|1024|**Product**|
|1025|**Product Association**|
|1026|**Price List Item**|
|1028|**Product Relationship**|
|1038|**Sales Literature**|
|1048|**Property**|
|1049|**Property Option Set Item**|
|1055|**Unit**|
|1056|**Unit Group**|
|1070|**Sales Attachment**|
|1080|**Discount List**|
|1083|**Opportunity Product**|
|1084|**Quote**|
|1085|**Quote Product**|
|1088|**Order**|
|1089|**Order Product**|
|1090|**Invoice**|
|1091|**Invoice Product**|
|1141|**Characteristic**|
|1142|**Rating Value**|
|1144|**Rating Model**|
|1145|**Bookable Resource Booking**|
|1146|**Bookable Resource Booking Header**|
|1147|**Bookable Resource Category**|
|1148|**Bookable Resource Characteristic**|
|1149|**Bookable Resource Category Assn**|
|1150|**Bookable Resource**|
|1151|**Bookable Resource Group**|
|1152|**Booking Status**|
|1235|**Property Association**|
|1333|**Property Instance**|
|2011|**Contract Template**|
|4000|**Facility/Equipment**|
|4001|**Service**|
|4002|**Resource**|
|4005|**Scheduling Group**|
|4006|**Resource Specification**|
|4007|**Resource Group**|
|4009|**Site**|
|4010|**Resource Expansion**|
|4206|**Case Resolution**|
|4208|**Opportunity Close**|
|4209|**Order Close**|
|4211|**Quote Close**|
|4214|**Service Activity**|
|4215|**Commitment**|
|4300|**Marketing List**|
|4301|**Marketing List Member**|
|4400|**Campaign**|
|4401|**Campaign Response**|
|4402|**Campaign Activity**|
|4403|**Campaign Item**|
|4404|**Campaign Activity Item**|
|4405|**Bulk Operation Log**|
|4406|**Quick Campaign**|
|4421|**Bookable Resource Booking to Exchange Id Mapping**|
|4503|**Opportunity Relationship**|
|4545|**Entitlement Template Product**|
|6363|**Entitlement Product**|
|7272|**Entitlement Contact**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9702|**Entitlement Template**|
|9703|**Entitlement Template Channel**|
|9704|**Entitlement Entity Allocation Type Mapping**|
|9820|**Attribute Masking Rule**|
|9931|**Incident KnowledgeBaseRecord**|
|9942|**Topic Model Configuration**|
|9943|**Topic Model Execution History**|
|9944|**Topic Model**|
|9946|**Topic History**|
|9948|**Text Analytics Topic**|
|9954|**Knowledge Article Incident**|
|10057|**CascadeGrantRevokeAccessRecordsTracker**|
|10058|**CascadeGrantRevokeAccessVersionTracker**|
|10059|**RevokeInheritedAccessRecordsTracker**|
|10060|**TdsMetadata**|
|10061|**Model-Driven App Element**|
|10062|**Model-Driven App Component Node's Edge**|
|10063|**Model-Driven App Component Node**|
|10064|**Model-Driven App Setting**|
|10065|**Model-Driven App User Setting**|
|10066|**Organization Setting**|
|10067|**Setting Definition**|
|10068|**CanvasApp Extended Metadata**|
|10069|**Service Plan Mapping**|
|10070|**Service Plan Custom Control**|
|10072|**ApplicationUser**|
|10075|**OData v4 Data Source**|
|10076|**Workflow Binary**|
|10077|**Credential**|
|10078|**Desktop Flow Module**|
|10079|**Flow Capacity Assignment**|
|10080|**Flow Event**|
|10081|**Flow Machine**|
|10082|**Flow Machine Group**|
|10083|**Flow Machine Image**|
|10084|**Flow Machine Image Version**|
|10085|**Flow Machine Network**|
|10086|**ProcessStageParameter**|
|10087|**Work Queue**|
|10088|**Work Queue Item**|
|10089|**Desktop Flow Binary**|
|10090|**Flow Run**|
|10091|**Connection Reference**|
|10092|**DVFileSearch**|
|10093|**DVFileSearchAttribute**|
|10094|**DVFileSearchEntity**|
|10095|**DVTableSearch**|
|10096|**DVTableSearchAttribute**|
|10097|**DVTableSearchEntity**|
|10098|**AIPlugin**|
|10099|**AIPluginExternalSchema**|
|10100|**AIPluginExternalSchemaProperty**|
|10101|**AIPluginInstance**|
|10102|**AIPluginOperation**|
|10103|**AIPluginOperationParameter**|
|10104|**AIPluginUserSetting**|
|10105|**Help Page**|
|10106|**Tour**|
|10107|**BotContent**|
|10108|**ConversationTranscript**|
|10109|**Chatbot**|
|10110|**Copilot component**|
|10118|**Comment**|
|10119|**PDF Setting**|
|10120|**Activity File Attachment**|
|10121|**Teams chat**|
|10122|**Service Configuration**|
|10123|**SLA KPI**|
|10124|**Integrated search provider**|
|10125|**Knowledge Management Setting**|
|10126|**Knowledge Federated Article**|
|10127|**Knowledge Federated Article Incident**|
|10128|**Search provider**|
|10129|**Knowledge Article Image**|
|10130|**Knowledge Configuration**|
|10131|**Knowledge Interaction Insight**|
|10132|**Knowledge Search Insight**|
|10133|**Favorite knowledge article**|
|10134|**Knowledge article language setting**|
|10135|**Knowledge Article Attachment**|
|10136|**Knowledge personalization**|
|10137|**Knowledge Article Template**|
|10138|**Knowledge search personal filter config**|
|10139|**Knowledge search filter**|
|10141|**SupportUserTable**|
|10142|**FxExpression**|
|10143|**PowerfxRule**|
|10144|**Ms Graph Resource To Subscription**|
|10145|**Virtual Entity  Metadata**|
|10146|**Background Operation**|
|10147|**MobileOfflineProfileExtension**|
|10148|**MobileOfflineProfileItemFilter**|
|10149|**TeamMobileOfflineProfileMembership**|
|10150|**UserMobileOfflineProfileMembership**|
|10151|**OrganizationDataSyncSubscription**|
|10152|**OrganizationDataSyncSubscriptionEntity**|
|10153|**OrganizationDataSyncSubscriptionFnoTable**|
|10154|**OrganizationDataSyncFnoState**|
|10155|**OrganizationDataSyncState**|
|10156|**ArchiveCleanupInfo**|
|10157|**ArchiveCleanupOperation**|
|10158|**BulkArchiveConfig**|
|10159|**BulkArchiveFailureDetail**|
|10160|**BulkArchiveOperation**|
|10161|**BulkArchiveOperationDetail**|
|10162|**EnableArchivalRequest**|
|10163|**MetadataForArchival**|
|10164|**ReconciliationEntityInfo**|
|10165|**ReconciliationEntityStepInfo**|
|10166|**ReconciliationInfo**|
|10167|**RetentionCleanupInfo**|
|10168|**RetentionCleanupOperation**|
|10169|**RetentionConfig**|
|10170|**RetentionFailureDetail**|
|10171|**RetentionOperation**|
|10172|**RetentionOperationDetail**|
|10173|**App Insights Metadata**|
|10174|**Dataflow Connection Reference**|
|10175|**Schedule**|
|10176|**Dataflow Template**|
|10177|**Dataflow DatalakeFolder**|
|10178|**Data Movement Service Request**|
|10179|**Data Movement Service Request Status**|
|10180|**DMS Sync Request**|
|10181|**DMS Sync Status**|
|10182|**Module Run Detail**|
|10183|**Workflow Action Status**|
|10184|**Notification**|
|10185|**User Rating**|
|10186|**Mobile App**|
|10187|**Insights Store Data Source**|
|10188|**Insights Store Virtual Entity**|
|10189|**RoleEditorLayout**|
|10190|**Deleted Record Reference**|
|10191|**Restore Deleted Records Configuration**|
|10192|**App Action**|
|10193|**App Action Migration**|
|10194|**App Action Rule**|
|10197|**Card**|
|10198|**Card State Item**|
|10201|**Entity link chat configuration**|
|10202|**Rich Text Attachment**|
|10203|**Custom Control Extended Setting**|
|10204|**Timeline Pin**|
|10205|**Virtual Connector Data Source**|
|10206|**Virtual Table Column Candidate**|
|10207|**AI Event**|
|10208|**AI Builder Feedback Loop**|
|10209|**AI Form Processing Document**|
|10210|**AI Object Detection Image**|
|10211|**AI Object Detection Label**|
|10212|**AI Object Detection Bounding Box**|
|10213|**AI Object Detection Image Mapping**|
|10215|**AI Builder Dataset**|
|10216|**AI Builder Dataset File**|
|10217|**AI Builder Dataset Record**|
|10218|**AI Builder Datasets Container**|
|10219|**AI Builder File**|
|10220|**AI Builder File Attached Data**|
|10221|**PM Analysis History**|
|10222|**PM Business Rule Automation Config**|
|10223|**PM Calendar**|
|10224|**PM Calendar Version**|
|10225|**PM Inferred Task**|
|10226|**PM Process Extended Metadata Version**|
|10227|**PM Process Template**|
|10228|**PM Process User Settings**|
|10229|**PM Process Version**|
|10230|**PM Recording**|
|10231|**PM Template**|
|10232|**PM View**|
|10233|**Analysis Component**|
|10234|**Analysis Job**|
|10235|**Analysis Override**|
|10236|**Analysis Result**|
|10237|**Analysis Result Detail**|
|10238|**Solution Health Rule**|
|10239|**Solution Health Rule Argument**|
|10240|**Solution Health Rule Set**|
|10241|**Power BI Dataset**|
|10242|**powerbidatasetapdx**|
|10243|**Power BI Mashup Parameter**|
|10244|**Power BI Report**|
|10245|**powerbireportapdx**|
|10246|**File Upload**|
|10247|**MainFewShot**|
|10248|**MakerFewShot**|
|10249|**SearchAttributeSettings**|
|10250|**SearchCustomAnalyzer**|
|10251|**SearchRelationshipSettings**|
|10252|**Search Telemetry**|
|10253|**CopilotExampleQuestion**|
|10254|**Site Component**|
|10255|**Site**|
|10256|**Site Language**|
|10257|**Power Pages Site Published**|
|10260|**External Identity**|
|10261|**Invitation**|
|10262|**Invite Redemption**|
|10263|**Portal Comment**|
|10264|**Setting**|
|10265|**Multistep Form Session**|
|10269|**Ad Placement**|
|10270|**Column Permission**|
|10271|**Column Permission Profile**|
|10272|**Content Snippet**|
|10273|**Basic Form**|
|10274|**Basic Form Metadata**|
|10275|**List**|
|10276|**Table Permission**|
|10277|**Page Template**|
|10278|**Poll Placement**|
|10279|**Power Pages Core Entity DS**|
|10280|**Publishing State**|
|10281|**Publishing State Transition Rule**|
|10282|**Redirect**|
|10283|**Shortcut**|
|10284|**Site Marker**|
|10285|**Site Setting**|
|10286|**Web File**|
|10287|**Multistep Form**|
|10288|**Multistep Form Metadata**|
|10289|**Form Step**|
|10290|**Web Link**|
|10291|**Web Link Set**|
|10292|**Web Page**|
|10293|**Web Page Access Control Rule**|
|10294|**Web Role**|
|10295|**Website**|
|10296|**Website Access**|
|10297|**Website Language**|
|10298|**Web Template**|
|10308|**Catalog Submission Files**|
|10309|**Package Submission Store**|
|10310|**List Operation**|
|10311|**Marketing Form Display Attributes**|
|10312|**Database Version**|
|10313|**Upgrade Run**|
|10314|**Upgrade Step**|
|10315|**Upgrade Version**|
|10316|**Activity monitor**|
|10317|**Originating Queue Mapping**|
|10318|**Unified Routing Setup Tracker**|
|10319|**Available Times**|
|10320|**Available Times Data Source**|
|10321|**resource group data source**|
|10322|**Virtual Resource Group Resource**|
|10323|**Migration tracker**|
|10324|**BgJobLedger**|
|10325|**Intent**|
|10326|**JobsState**|
|10327|**Asset Category Template Association**|
|10328|**Asset Template Association**|
|10329|**Customer Asset**|
|10332|**Customer Asset Attachment**|
|10333|**Customer Asset Category**|
|10334|**Functional Location**|
|10335|**Property Definition**|
|10336|**Property Asset Association**|
|10337|**Property Log**|
|10338|**Property Template Association**|
|10339|**Template For Properties**|
|10343|**IoT Alert**|
|10344|**IoT Device**|
|10345|**IoT Device Category**|
|10346|**IoT Device Command**|
|10347|**IoT Device Command Definition**|
|10348|**IoT Device Data History**|
|10349|**IoT Device Property**|
|10350|**IoT Device Registration History**|
|10351|**IoT Device Visualization Configuration**|
|10352|**IoT Field Mapping**|
|10353|**IoT Property Definition**|
|10354|**IoT Provider**|
|10355|**IoT Provider Instance**|
|10356|**IoT Settings**|
|10359|**IoT Alert to Case Process**|
|10361|**Playbook Callable Context**|
|10362|**Playbook activity**|
|10363|**Playbook activity attribute**|
|10364|**[DEPRECATED] Playbook category**|
|10365|**Playbook**|
|10366|**[DEPRECATED] Playbook template**|
|10368|**admin_settings_entity**|
|10369|**Collab Space Team Association**|
|10370|**CRM Connection**|
|10371|**Tagged Record**|
|10372|**Copilot for Sales customer list**|
|10373|**msdyn_vivaentitysetting**|
|10374|**msdyn_vivaorgextensioncred**|
|10375|**msdyn_vivaorgsetting**|
|10376|**msdyn_vivausersetting**|
|10377|**Sales Copilot Insight**|
|10378|**Org level settings for Sales Copilot apps**|
|10379|**App profile**|
|10380|**Application Extension**|
|10381|**Application Tab Template**|
|10382|**App profile role mapping**|
|10383|**Notification Field**|
|10384|**Notification Template**|
|10385|**Session Template**|
|10386|**Template Parameter**|
|10392|**Channel Integration Framework v1.0 Provider**|
|10393|**Notification Field (Deprecated)**|
|10394|**Notification Template (Deprecated)**|
|10395|**App Parameter Definition (Deprecated)**|
|10396|**Session Templates (Deprecated)**|
|10397|**Application Tab Template (Deprecated)**|
|10398|**Parameter (Deprecated)**|
|10399|**Template Tag (Deprecated)**|
|10400|**Application Type (Deprecated)**|
|10409|**Channel Integration Framework v2.0 Provider**|
|10411|**Conversation Data (Deprecated)**|
|10412|**KPI Event Data**|
|10413|**KPI Event Definition**|
|10414|**Session Data (Deprecated)**|
|10415|**Session Participant Data (Deprecated)**|
|10416|**Channel Definition**|
|10417|**Channel Definition Consent**|
|10418|**Channel Definition Locale**|
|10419|**Channel Instance**|
|10420|**Channel Instance Account**|
|10421|**Channel Message Attachment**|
|10422|**Channel Message Context Part**|
|10423|**Channel Message Part**|
|10424|**Consuming Application**|
|10425|**msdyn_DefExtendedChannelInstance**|
|10426|**msdyn_DefExtendedChannelInstanceAccount**|
|10427|**Productivity pane configuration**|
|10428|**Pane tab configuration**|
|10429|**Pane tool configuration**|
|10431|**Agent script**|
|10432|**Agent script step**|
|10434|**Action Input Parameter**|
|10435|**Action Output Parameter**|
|10436|**Macro Action Template**|
|10437|**Macro Solution Configuration**|
|10438|**Macro Connector**|
|10439|**Macro Run History**|
|10440|**Parameter definition**|
|10443|**Adaptive Card Configuration**|
|10444|**Smartassist configuration**|
|10446|**Read Tracker**|
|10447|**Read tracking enabled information**|
|10448|**Microsoft Teams Graph resource Entity**|
|10449|**msdyn_msteamssetting**|
|10450|**msdyn_msteamssettingsv2**|
|10451|**Microsoft Teams Collaboration entity**|
|10452|**Teams Dialer Admin settings**|
|10453|**Teams Contact Suggestion by AI**|
|10454|**Contact suggestion rule**|
|10455|**Contact suggestion ruleset**|
|10456|**Microsoft Teams chat association entity**|
|10457|**Microsoft Teams chat suggestion**|
|10458|**Microsoft Orgchart node entity**|
|10459|**Forecast Manual Adjustment History**|
|10460|**Distributed Lock**|
|10461|**Entity Delta Change**|
|10462|**File Upload Status Tracker**|
|10463|**Forecast**|
|10464|**Forecast Configuration**|
|10465|**Forecast definition**|
|10466|**Forecasting Cache**|
|10467|**Forecast Insights**|
|10468|**Forecast**|
|10469|**Forecast Prediction Data**|
|10470|**Forecast Prediction Status**|
|10471|**Forecast recurrence**|
|10472|**Recompute Tracker**|
|10473|**Forecast Recurrence**|
|10474|**ShareAs Configuration**|
|10475|**Customer email communication**|
|10476|**GDPRData**|
|10477|**ODOSFeatureMetadata**|
|10478|**ODOSMetadata**|
|10479|**Recurring Sales Action**|
|10480|**Recurring Sales Action V2**|
|10481|**msdyn_relationshipinsightsunifiedconfig**|
|10482|**siconfig**|
|10483|**SI Key Value Config**|
|10484|**Usage Metric**|
|10485|**Action Card Regarding**|
|10486|**Action Card Role Setting**|
|10487|**EntityRankingRule**|
|10488|**flowcardtype**|
|10489|**salesinsightssettings**|
|10490|**Action Card Usage**|
|10491|**Action Card Usage Aggregation**|
|10492|**Auto Capture Rule**|
|10493|**Auto Capture Settings**|
|10494|**UntrackedAppointment**|
|10495|**Suggested Activity**|
|10496|**Suggested Activity Data Source**|
|10497|**Suggested Contact**|
|10498|**Suggested Contacts Data Source**|
|10499|**Notes analysis Config**|
|10500|**icebreakersconfig**|
|10501|**dealmanageraccess**|
|10502|**Deal manager settings**|
|10503|**Account KPI Item**|
|10504|**Activity Analysis CleanUp State**|
|10505|**Relationship Analytics Config**|
|10506|**Contact KPI Item**|
|10507|**Daily Kpis for account**|
|10508|**Daily kpis for contact**|
|10509|**Daily kpis for lead**|
|10510|**Daily kpis for Opportunity**|
|10511|**Lead KPI Item**|
|10512|**Most Contacted**|
|10513|**Most Contacted By**|
|10514|**Opportunity KPI Item**|
|10515|**Relationship Analytics Metadata**|
|10516|**Similar entities feature importance**|
|10517|**wkwcolleaguesforcompany**|
|10518|**wkwcolleaguesforcontact**|
|10519|**wkwconfig**|
|10520|**Attribute Influence Statistics**|
|10521|**Prediction Computation Operation**|
|10522|**Prediction Model Status**|
|10523|**Prediction Scheduled Operation**|
|10524|**Predictive Model Score**|
|10525|**Predictive Score**|
|10526|**Predictive Scoring Sync Status**|
|10527|**Real Time Scoring**|
|10528|**Real Time Scoring Operation**|
|10529|**Submodel Definition**|
|10530|**Time spent in BPF**|
|10531|**Training Result**|
|10532|**OpportunityModelConfig**|
|10535|**LeadModelConfig**|
|10536|**ModelPreviewStatus**|
|10537|**Profile Album**|
|10538|**Post Configuration**|
|10539|**Post Rule Configuration**|
|10540|**Wall View**|
|10541|**Filter**|
|10542|**Customer Voice alert**|
|10543|**Customer Voice alert rule**|
|10544|**Customer Voice survey email template**|
|10545|**Customer Voice file response**|
|10546|**Customer Voice localized survey email template**|
|10547|**Customer Voice project**|
|10548|**Customer Voice survey question**|
|10549|**Customer Voice survey question response**|
|10550|**Customer Voice satisfaction metric**|
|10551|**Customer Voice survey**|
|10552|**Customer Voice survey invite**|
|10553|**Customer Voice survey reminder**|
|10554|**Customer Voice survey response**|
|10555|**Customer Voice unsubscribed recipient**|
|10556|**AddToCalendar style**|
|10557|**basestyle**|
|10558|**Button style**|
|10559|**Code style**|
|10560|**Column style**|
|10561|**Content Block**|
|10562|**Divider style**|
|10563|**General styles**|
|10564|**imagestyle**|
|10565|**Layout Style**|
|10566|**QR code style**|
|10567|**Text style**|
|10568|**Video style**|
|10569|**App state**|
|10570|**CSAdminConfig**|
|10571|**Custom API Ruleset Configuration**|
|10572|**Decision contract**|
|10573|**Decision rule set**|
|10574|**Rulesetentitymapping**|
|10575|**Routing diagnostic item**|
|10576|**Routing diagnostic**|
|10577|**Inbox card configuration**|
|10578|**Inbox Configuration**|
|10579|**Inbox Entity Configuration**|
|10580|**App Profile Copilot Configuration**|
|10581|**Agent Copilot Setting**|
|10582|**Copilot Summarization Setting**|
|10583|**Case Enrichment**|
|10584|**Case Suggestion**|
|10585|**Case Suggestion Request Payload**|
|10586|**Case Suggestions Data Souce**|
|10587|**Agent Preference For Copilot**|
|10588|**Copilot Interaction**|
|10589|**Copilot Interaction Data**|
|10590|**Copilot Transcript**|
|10591|**Copilot Transcript Data**|
|10592|**KB Enrichment**|
|10593|**Knowledge Article Suggestion**|
|10594|**Knowledge Article Suggestion Data Source**|
|10595|**Service Copilot Plugin**|
|10596|**Service Copilot Plugin Role**|
|10597|**Suggestion Interaction**|
|10598|**Suggestion request payload**|
|10599|**Suggestions Model Summary**|
|10600|**Suggestions Setting**|
|10601|**Swarm**|
|10602|**Swarm participant**|
|10603|**Swarm participant rule**|
|10604|**Swarm role**|
|10605|**Swarm skill**|
|10606|**Swarm template**|
|10607|**Entity Attachment**|
|10608|**Customer Service Key Value Configuration**|
|10609|**Master Entity Routing Configuration**|
|10610|**Routing Rule Set Setting**|
|10611|**Assignment Configuration**|
|10612|**Assignment Configuration Step**|
|10613|**Capacity Profile**|
|10614|**Overflow Action Config**|
|10615|**Preferred Agent**|
|10616|**Preferred Agent Customer Identity**|
|10617|**Preferred Agent Routed Entity**|
|10618|**Routing configuration**|
|10619|**Routing configuration step**|
|10620|**Bot Channel Registration**|
|10621|**Channel Configuration**|
|10622|**Channel State Configuration**|
|10623|**Provisioning State**|
|10624|**AdminAppState**|
|10625|**Agent Status history**|
|10626|**Power BI Configuration**|
|10627|**Authentication Settings**|
|10628|**Auth Settings Entry**|
|10629|**Quick reply**|
|10630|**Entity Routing Context**|
|10631|**Channel Capability**|
|10632|**Conversation Action**|
|10633|**Conversation Action Locale**|
|10634|**Conversation Message Block**|
|10635|**DeletedConversation**|
|10636|**Deprecated Workstream Entity Configuration**|
|10637|**Entity**|
|10638|**Ongoing conversation (Deprecated)**|
|10639|**Live work item event**|
|10640|**Work Stream**|
|10641|**Masking Rule**|
|10642|**Auto block rule**|
|10643|**Bot Channel Registration Secret**|
|10644|**Omnichannel channel api conversation privilege**|
|10645|**Omnichannel channel api message privilege**|
|10646|**Channel api method mapping**|
|10647|**External context**|
|10648|**Flagged spam**|
|10649|**Language**|
|10650|**Conversation**|
|10653|**Context item value**|
|10654|**Live Work Item Participant (Deprecated)**|
|10655|**Conversation Sentiment**|
|10656|**Context variable**|
|10657|**Localization**|
|10658|**OC Payment Profile**|
|10659|**Recording**|
|10660|**Omnichannel Request**|
|10661|**Rich message**|
|10662|**Rich message map**|
|10663|**Rule Item**|
|10664|**Sentiment daily topic**|
|10665|**Sentiment daily topic keyword**|
|10666|**Sentiment daily topic trending**|
|10667|**Session**|
|10668|**Session Participant Event**|
|10669|**Session Sentiment**|
|10670|**Message**|
|10671|**Tag**|
|10672|**Geo Location Provider**|
|10673|**Omnichannel Configuration**|
|10674|**Omnichannel Personalization**|
|10675|**Omnichannel Queue (Deprecated)**|
|10676|**Omnichannel Sync Config**|
|10677|**Operating Hour**|
|10678|**Personal quick reply**|
|10679|**Personal sound setting**|
|10680|**Persona Security Role Mapping**|
|10681|**Presence**|
|10682|**Provider**|
|10683|**RoutingRequest**|
|10684|**Search Configuration**|
|10685|**Sentiment analysis**|
|10686|**Session event**|
|10687|**Session participant**|
|10688|**Audio File**|
|10689|**Sound notification setting**|
|10690|**Transcript**|
|10691|**UR notification template**|
|10692|**UR Notification Template Mapping**|
|10693|**User settings**|
|10694|**Self service**|
|10701|**Agent capacity update history**|
|10702|**Bookable Resource Capacity Profile**|
|10703|**Work stream capacity profile**|
|10704|**Conversation Capacity profile**|
|10705|**Agent Capacity Profile Unit**|
|10706|**Agent Channel State**|
|10707|**Agent Status**|
|10708|**Conversation Characteristic**|
|10709|**Session Characteristic**|
|10710|**Skill Attachment Rule**|
|10711|**Attach Skill**|
|10712|**Model training details**|
|10713|**Training data import configuration**|
|10714|**Characteristic mapping**|
|10715|**Training record**|
|10716|**Skill finder model**|
|10717|**Effort estimate**|
|10718|**Effort estimation model**|
|10719|**Effort model training details**|
|10720|**ConversationInsight**|
|10721|**Active ICD Extension**|
|10722|**Entity-Workstream Map**|
|10723|**ICD Extension**|
|10724|**Conversation Action Item**|
|10725|**Conversation Aggregated Insights**|
|10726|**Comment**|
|10727|**Conversation Participant Insights**|
|10728|**Conversation Participant Sentiment**|
|10729|**Conversation Question**|
|10730|**Conversation Segment Sentiment**|
|10731|**Conversation Sentiment**|
|10732|**Conversation Signal**|
|10733|**Conversation Subject**|
|10734|**Conversation Summary Suggestion**|
|10735|**Conversation System Tag**|
|10736|**Conversation Tag**|
|10737|**Recording (Deprecated)**|
|10738|**SCI Conversation**|
|10739|**Custom Email Highlight**|
|10740|**Custom Highlight**|
|10741|**Custom Publisher**|
|10742|**EnvironmentSettings**|
|10743|**UserSettings**|
|10744|**CatalogEventStatusConfiguration**|
|10745|**Configuration**|
|10746|**Trigger**|
|10747|**Triggers To Sdk Message Processing Steps**|
|10748|**EventParameterMetadata**|
|10749|**TrackingContext**|
|10750|**Marketing feature configuration**|
|10751|**msdynmkt_experimentv2**|
|10752|**ACS channel instance**|
|10753|**ACS channel instance account**|
|10754|**Infobip channel instance**|
|10755|**Infobip channel instance account**|
|10756|**Link mobility channel instance**|
|10757|**Link mobility channel instance account**|
|10758|**MockSmsProvider channel instance**|
|10759|**MockSmsProvider channel instance account**|
|10760|**TeleSign channel instance**|
|10761|**TeleSign channel instance account**|
|10762|**Twilio channel instance**|
|10763|**Twilio channel instance account**|
|10764|**Vibes channel instance**|
|10765|**Vibes channel instance account**|
|10766|**Predefined Placeholder**|
|10767|**Metadata Entity Relationship**|
|10768|**Metadata Item**|
|10769|**Metadata Store State**|
|10770|**DigitalSellingActiveTask**|
|10771|**DigitalSellingCompletedTask**|
|10772|**Sales Tag**|
|10773|**Sequence**|
|10774|**Sequence Stat**|
|10775|**Sequence Target**|
|10776|**Sequence Target Step**|
|10777|**Sequence Template**|
|10779|**sabackupdiagnostic**|
|10780|**SABatchRunInstance**|
|10781|**salesroutingdiagnostic**|
|10782|**SARunInstance**|
|10783|**Segment**|
|10784|**segmentsetting**|
|10785|**Segment property**|
|10786|**SegmentsUtil**|
|10787|**Assignment Rule**|
|10788|**Seller attribute**|
|10789|**Seller attribute value**|
|10790|**Assignment Map**|
|10791|**Sales Assignment Setting**|
|10792|**Sales routing run**|
|10794|**Extended User Setting**|
|10795|**Sales acceleration insights**|
|10796|**Sales Acceleration settings**|
|10797|**Insight**|
|10798|**Work List Suggestion**|
|10799|**Work list suggestion source**|
|10800|**Work List View Configuration**|
|10801|**Work Queue Record**|
|10802|**Work Queue Record State**|
|10803|**Work list user setting**|
|10804|**WQDataSource**|
|10805|**Suggestion Assignment Rule**|
|10806|**Suggestion Principal Object Access**|
|10807|**Suggestion Seller Priority**|
|10808|**Data Hygiene Setting Info**|
|10809|**Duplicate Detection Plugin Run**|
|10810|**Duplicate Lead Mapping**|
|10811|**Lead Hygiene Setting**|
|10812|**Linked Entity Attribute Validity**|
|10813|**Sales provisioning request**|
|10814|**SalesOmnichannel Message**|
|10815|**Text message template**|
|10816|**Data Analytics Admin Settings (Deprecated)**|
|10817|**Data Analytics Report**|
|10818|**Insights**|
|10819|**Sales acceleration reports**|
|10821|**Bot Session**|
|10822|**conversationsuggestionrequestpayload**|
|10823|**Data Analytics User Customized Report**|
|10824|**Data Analytics Dataset**|
|10825|**Data Analytics Workspace**|
|10826|**Report Bookmark**|
|10827|**Agent Resource Forecasting**|
|10828|**[Deprecated] Dynamics Customer Service Analytics**|
|10829|**Case Topic**|
|10830|**Case Topic Setting**|
|10831|**Case Topic Summary**|
|10832|**Case topic Incident mapping**|
|10833|**Customer Service historical analytics**|
|10834|**Forecast**|
|10835|**Knowledge analytics**|
|10836|**Forecast Summary and Setting**|
|10837|**Keywords Description Suggestion Setting**|
|10908|**Autonomous case creation and update rules**|
|11003|**Conversation Summary Interaction**|
|11004|**Conversation Summary Setting**|
|11005|**Conversation Topic**|
|11006|**Conversation Topic Setting**|
|11007|**Conversation Topic Summary**|
|11008|**Conversation topic Conversation mapping**|
|11009|**Omnichannel historical analytics**|
|11010|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|11011|**Omnichannel Realtime analytics**|
|11012|**SearchResultsCache**|
|11028|**Flow Credential Application**|
|11029|**Sales usage telemetry reports**|
|11030|**Sales usage reporting**|
|11031|**Sales Copilot User Setting**|
|11032|**Omnichannel agent assignment custom api privilege**|
|11033|**Planner Business Scenario**|
|11034|**Planner Sync Action**|
|11035|**CopilotGlossaryTerm**|
|11036|**CopilotSynonyms**|
|11056|**Property Location Association**|
|11057|**Flow Log**|
|11058|**Copilot component collection**|
|11064|**AICopilot**|
|11065|**AI Plugin Conversation Starter**|
|11066|**AI Plugin Conversation Starter Mapping**|
|11067|**AI Plugin Governance**|
|11068|**AI Plugin Governance Extended**|
|11069|**AIPluginOperationResponseTemplate**|
|11070|**AIPluginTitle**|
|11071|**SideloadedAIPlugin**|
|11078|**Location Template Association**|
|11082|**Power Pages Scan Report**|
|11083|**Power Pages Log**|
|11085|**PM Simulation**|
|11086|**Fabric AISkill**|
|11087|**Knowledge Asset Configuration**|
|11088|**Salesforce Structured Object**|
|11089|**Salesforce Structured QnA Config**|
|11100|**Functional Location Type Template Association**|
|11101|**Functional Location Type**|
|11102|**Warranty**|
|11106|**AIPluginAuth**|
|11110|**Lock Status**|
|11112|**ViewAsExampleQuestion**|
|11123|**Survey setting**|
|11125|**Copilot Analytics**|
|11126|**FederatedKnowledgeConfiguration**|
|11127|**FederatedKnowledgeEntityConfiguration**|
|11129|**Form Mapping**|
|11130|**Case follow up and closure configuration**|
|11131|**Next Action**|
|11132|**Automated action rule**|
|11133|**Automated action rules mapping**|
|11134|**Time Tracker**|
|11135|**Report Parameter**|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.importmap?displayProperty=fullName>
