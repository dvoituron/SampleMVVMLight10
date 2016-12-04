<%@ Page Language="C#" %>

<%
    string jsonFile = System.IO.File.ReadAllText(Server.MapPath("Friends.json"));
    string currentPath = string.Format("{0}://{1}:{2}{3}", Request.Url.Scheme, Request.Url.Host, Request.Url.Port, Request.ApplicationPath);

    jsonFile = jsonFile.Replace("\"Picture\": \"", "\"Picture\": \"" + currentPath);

    Response.Write(jsonFile);
%>