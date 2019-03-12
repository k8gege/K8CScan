library CscanDll;
uses

  SysUtils,Classes; 

function scan(ip:PChar):PAnsiChar;stdcall;
  begin
  //this is you Code
    if Length(ip) <=0 then
      Result := PChar('is null')
    else
      Result := PChar(ip);
  end;

exports scan;

begin
end.