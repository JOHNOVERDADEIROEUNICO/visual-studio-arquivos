import urllib
import urllib.error
import urllib.request

try:
    site = urllib.request.urlopen('https://www.youtube.com')

except urllib.error.URLError:
    print('Este site não está ativo no momento.')

else:
    print('Este site está funcionando normalmente')
    print(site.read())