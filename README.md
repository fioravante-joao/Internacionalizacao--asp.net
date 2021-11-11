# Internacionalizacao-asp.net
Internacionalização de aplicação Asp.Net MVC nos idiomas pt-BR e en-US

# Implementação de Web Resources no ASP.NET MVC

1 - Primeiramente vá até a Solution Explorer - > abara o arquivo Web.config ->
dentro da Tag <system.web> adicione a tag Filho <globalization culture="pt-BR" uiCulture="auto:pt-BR" />,
essa tag de globalização fará a detecção automatica de idioma.
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/InternacionalizacaoWebConfig.png" width="1000" height="500" title="hover text">
</p>

2 - Os Web Resources, ou "Global resources", são recursos adicionados
à sua "Aplicação Web", cada um com um valor diferente para suas chaves e que, ao 
solicitarem determinado conteúdo de determinada "língua", eles entregam o conteúdo 
que foi cadastrado para ele. Os Web Resources são arquivos XML.

3 - Então vamos lá inserir o diretório "App_GlobalResources" em nossa Aplicação Web,
para isso clique com o botão direito do mouse em seu projeto > Add > Add ASP.NET Folder.
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/AppGlobalResources.png" width="1000" height="500" title="hover text">
</p>

4 - Após criar o diretório "App_GlobalResources", clique bom o botão direito nele > Add > 
"Resource Files "
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/AddResourceFiles.png" width="1000" height="500" title="hover text">
</p>
usaremos um para cada língua escolhida, tendo cada uma um sufixo com o código
da língua. Por exemplo: teremos uma página com informações sobre o ASP.NET em português, inglês,
então teremos 2 arquivos do tipo "Resources File" com os seguintes nomes (aspnet.resx) para o Português
que será Default e para o Inglês será (aspnet.en.resx).
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/ResourceFiles-Idiomas.png" width="1000" height="500" title="hover text">
</p>

5 - caso queira acrescentar outros idiomas é só ir criando novos arquivo do tipo (Resources File) e renomeando ele com
"aspnet.CÓDIGO DA LINGUAGEM DESEJADA.resx".

# COMO USAR/TESTAR

1 - Abara o arquivo (aspnet.resx) para português, crie na coluna "Name" > "labelTitulo",  e na coluna "Value" > Oiiiiii! .
Agora abara o arquivo (aspnet.en.resx) para o inglês crie na coluna "Name" > "labelTitulo", e na coluna "Value" > Hellooooo! .

pt-BR
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/Resource-em-pt-BR.png" width="1000" height="300" title="hover text">
</p>

en-US
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/resource-em-en-US.png" width="1000" height="300" title="hover text">
</p>

Vá na view Index da sua aplicação e insira uma uma tag chamando a labelTitulo que você criou nas suas Resources Ex:
<h1>@Resources.aspnet.labelTitulo</h1>

Feito isso, salve a aplicação de dê um Rebuild, após isso inicie sua aplicação precionando as teclas Ctrl + F5  ou simplesmente F5,
caso seu navegador esteja configurado no idioma pt-BR a mensagem de labelTitulo aparecerá em Português, mas se o navegador estiver no idioma Inglês,
a labelTitulo será exibida com o Value "Hellooooo!" e, inglês;

navegador en-US
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/Navegador-en-Us.png" width="1000" height="300" title="hover text">
</p>

navegador pt-BR
<p align="center">
  <img src="https://bela-estudo-s3.s3.sa-east-1.amazonaws.com/navegador-pt-BR.png" width="1000" height="300" title="hover text">
</p>

Fim...

@REFERENCIAS DE ESTUDO:

https://imasters.com.br/dotnet/internacionalizacao-de-sites-asp-net
