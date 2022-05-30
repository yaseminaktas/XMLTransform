<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:xs="http://www.w3.org/2001/XMLSchema"
    exclude-result-prefixes="xs" xmlns:tem="http://tempuri.org/"
    xmlns:xslt-functions="http://mdpgroup.com/xslt-functions"
    xmlns:ns1="urn:sap-com:document:sap:soap:functions:mc-style"
    version="2.0" >
	<xsl:output indent="yes" method="xml"/>
	<xsl:template match="*">
		<xsl:choose>
			<xsl:when test="//ISavePdf = 'X'">
				<tem:GetInvoice_PDF>
					<tem:getInvoice_ETTN>
						<tem:Login_Request_Header>
							<tem:Session_ID>
								<xsl:value-of select="xslt-functions:getProperty('SessionID')"/>
							</tem:Session_ID>
							<tem:IP_Number>
								<xsl:value-of select="xslt-functions:getProperty('IPNumber')"/>
							</tem:IP_Number>
							<tem:Security_Key>
								<xsl:value-of select="xslt-functions:getProperty('SecurityKey')"/>
							</tem:Security_Key>
						</tem:Login_Request_Header>
						<tem:ETTN>
							<xsl:value-of select="//UUID"/>
						</tem:ETTN>
					</tem:getInvoice_ETTN>
				</tem:GetInvoice_PDF>
			</xsl:when>
			<xsl:when test="//IOutputType = '5'">
				<tem:GetInvoice_XML_List>
					<tem:getInvoice_ETTN_List>
						<tem:Login_Request_Header>
							<tem:Session_ID>
								<xsl:value-of select="xslt-functions:getProperty('SessionID')"/>
							</tem:Session_ID>
							<tem:IP_Number>
								<xsl:value-of select="xslt-functions:getProperty('IPNumber')"/>
							</tem:IP_Number>
							<tem:Security_Key>
								<xsl:value-of select="xslt-functions:getProperty('SecurityKey')"/>
							</tem:Security_Key>
						</tem:Login_Request_Header>
						<tem:ETTNs>
							<tem:string>
								<xsl:value-of select="//UUID"/>
							</tem:string>
						</tem:ETTNs>
					</tem:getInvoice_ETTN_List>
				</tem:GetInvoice_XML_List>
			</xsl:when>
			<xsl:otherwise>
				<tem:GetInvoice_HTML>
					<tem:getInvoice_ETTN>
						<tem:Login_Request_Header>
							<tem:Session_ID>
								<xsl:value-of select="xslt-functions:getProperty('SessionID')"/>
							</tem:Session_ID>
							<tem:IP_Number>
								<xsl:value-of select="xslt-functions:getProperty('IPNumber')"/>
							</tem:IP_Number>
							<tem:Security_Key>
								<xsl:value-of select="xslt-functions:getProperty('SecurityKey')"/>
							</tem:Security_Key>
						</tem:Login_Request_Header>
						<tem:ETTN>
							<xsl:value-of select="//UUID"/>
						</tem:ETTN>
					</tem:getInvoice_ETTN>
				</tem:GetInvoice_HTML>
			</xsl:otherwise>
		</xsl:choose>

	</xsl:template>
</xsl:stylesheet>