   M S B A M L   `   `   `  ����M  IprevencionDiabetes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:prevencionDiabetesprevencionDiabetes  5   	   #    prevencionDiabetes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:prevencionDiabetes     5   	     � Title$  
MainWindow��5   	    � 
ResizeMode$ NoResize=�6   $	��500��62   $
��1201��6?   .��5	      �  � RowDefinitions 5
   
   �� 5       � ColumnDefinitions 5   
   �� 5      $
��179* �6   �� 5      $��1022* �6   .+�5   
   �� $��Último acceso��6   $
��Left=�6(   $��
12,291,0,0q�6C   $	��Top=�6W   $��Verdana)�6o   $��25��6�   $��94��6�   �� 5   
   -   5         ��Name$ btnCerrarSesion��5      $��Cerrar sesión��6*   $��Center=�6B   $	��Top=�6_   $��Verdana)�6w   $��34��6�   $	��106��6�   $��	0,410,0,0q�6�   ���	#FF7B95E6$
��Bold"�6�   
����������	#FF7B95E66  �� 5   
   -   5         ��Name$ 	lblAcceso��5      $�� ��6#   $��Center=�6.   $	��Top=�6K   $��26��6c   $	��156��6o   $
��Bold"�6{   $��	0,321,0,0q�6�   �� 5   
   $��Email��6   $
��Left=�6    $��12,0,0,0q�6;   $��Center=�6M   $��26��6h   $��46��6t   �� 5   
   -   5        $ lblEmail��5      $�� ��6"   $��Center=�6-   $	��Top=�6J   $��26��6b   $	��156��6n   $��	0,252,0,0q�6z   $
��Bold"�6�   �� 5   
   $��Usuario��6   $
��Left=�6"   $��
12,154,0,0q�6=   $	��Top=�6Q   $��26��6i   $��54��6u   �� 5   
   -   5        $ 	lblNombre��5      $�� ��6#   $��Center=�6.   $��	0,185,0,0q�6K   $	��Top=�6^   $
��Bold"�6v   $��26��6�   $	��156��6�   �� 5   
   $��1��6   $��Center=�6%   $��0,0,0,10q�6B   $
��1002��6T   .@�5      �� $
��Home��6   .��5      � .+�5      �� $!��¡Bienvenido/a a FindRisk! ��6   $
��Left=�6A   $��	20,29,0,0q�6\   $	��Top=�6o   $��20(�6�   $
��Bold"�6�   �� 5      $��¿Qué es la diabetes?��6   $
��Left=�6;   $��	48,84,0,0q�6V   $	��Top=�6i   $��16(�6�   $
��Bold"�6�   �� 5      $
��Left=�6    $��
48,120,0,0q�6;   $
��Wrap=�6O   $����La diabetes es una enfermedad crónica que afecta a millones de personas en todo el mundo. Si bien es cierto que la diabetes puede ser controlada,                                                       también es cierto que no se puede curar, y si no se trata adecuadamente puede tener consecuencias graves para la salud.��6c   $	��Top=�5    �   �� 5!      $
��Left=�6    $��
48,170,0,0q�6;   $
��Wrap=�6O   $����La diabetes es una enfermedad en la que el cuerpo no produce suficiente insulina o no la utiliza adecuadamente. La insulina es una hormona que se                                                                 encarga de regular el nivel de azúcar en la sangre. Cuando hay demasiada azúcar en la sangre, puede causar daño a los órganos y tejidos del cuerpo,                                                                como los ojos, los riñones, los nervios y el corazón.��6c   $	��Top=�5%   W   �� 5&      $
��Left=�6    $��
48,239,0,0q�6;   $
��Wrap=�6O   $����Las personas con diabetes deben controlar cuidadosamente sus niveles de azúcar en la sangre, ya sea mediante dieta y ejercicio, medicamentos,                                                                insulina o una combinación de estos métodos. Es importante hacerse controles médicos regulares y seguir las indicaciones del médico para                                                                prevenir complicaciones.��6c   $	��Top=�5*   :   �� 5+      $��¿Qué vas a encontrar?��6   $
��Left=�6<   $��
48,313,0,0q�6W   $	��Top=�6k   $��16(�6�   $
��Bold"�6�   �� 5,      $
��Left=�6    $��
48,349,0,0q�6;   $
��Wrap=�6O   $����Existen tres tipos de diabetes (de tipo 1, 2 y diabetes gestacional), bueno pues la más común y la que padece entre el 90-95% de las personas que                                                                 padecen diabetes es la Diabetes de Tipo 2. En nuestra aplicación intentamos evitar este tipo de diabetes y para ello hemos creado un formulario                                                                 para conseguir esto.��6c   $	��Top=�50   6   �� 51      $?��9Para más información visite https://fedesp.es/diabetes/��6   $
��Left=�6^   $��45,0,0,0q�6y   $��Bottom=�6�   52      53      �� 55      $��
Formulario��6   .��56      �  57      �� 58      $
��120* �6(   �� 59      $	��15* �6(   �� 5:      $	��30* �6(   .+�5<      � $��0��6    5=      �� 5>      $	��30* �6/   �� 5?      $	��30* �6/   �� 5@      $	��30* �6/    5B      �� 5C      $	��30* �6,   �� 5D      $	��30* �6,   �� 5E      $	��30* �6,   �� 5F      $	��30* �6,   �� 5G      $	��30* �6,   �� 5H      $	��30* �6,   �� 5I      $	��30* �6,   .+�5K      ��  �� Orientation$ 
Horizontal=�6%   $��0��6>   $��0��6K   $��Right=�6[   $��2q�6w   .+�5L      �� $
��Sexo��6$   $��0��63   $��0��6@   $
��Left=�6P   $��Bottom=�6k   $��34��6�   $��35��6�   d� 5M      -   5         d�Name$ btnSexoHombre��5M   +   $��Hombre��6B   $��Right=�6S   
����������	#FF7B95E6$��Bottom=�6�   $��34��6�   $
��78.5��6�   $
��Bold"�6�   6�   d� 5N      -   5        $ btnSexoMujer��5N   +   $��Mujer��6A   $��Right=�6Q   
����������	#FF7B95E6$��Bottom=�6�   $��34��6�   $
��78.5��6�   $
��Bold"�6�   6�   5O      �� 5P      $ 
Horizontal=�6%   $��1��6>   $��0��6K   $��Right=�6[   $��0,11,0,0q�6w   .+�5Q      �� $
��Edad��6$   $��1��63   $��0��6@   $
��Left=�6P   $��Center=�6k   $��26��6�   $��36��6�   d� 5R      -   5        $ btnEdadMenos45��5R   +   $��1��6C   $��0��6P   
����������	#FF7B95E6$)��#<45                               0��6�   $��Right=�6�   $��Bottom=�6�   $��34��6�   $	��158��6�   $
��Bold"�6
  6  5S      d� 5T      -   5        $ btnEdadEntre45y54��5T   '   $��2��6B   $��0��6O   
����������	#FF7B95E6$'��!45-54                          +2��6�   $��Right=�6�   $��Bottom=�6�   $��34��6�   $	��158��6�   $
��Bold"�6  6  d� 5U      -	   5        $ btnEdadEntre55y64��5U   '   $��3��6B   $��0��6O   
����������	#FF7B95E6$&�� 55-64                         +3��6�   $��Right=�6�   $��Bottom=�6�   $��34��6�   $	��158��6�   $
��Bold"�6  6  d� 5V      -
   5        $ btnEdadMas65��5V   '   $��4��6=   $��0��6J   
����������	#FF7B95E6$'��!>64                            +4��6�   $��Right=�6�   $��Bottom=�6�   $��34��6�   $	��158��6�   $
��Bold"�6  6  �� 5W      $ 
Horizontal=�6%   $��5��6>   $��0��6K   $��Bottom=�6[   $��Right=�6v   $��2q�6�   .+�5X      �� $��Actividad física��6$   $��Right=�6?   $��0��6[   $��5��6k   $��Center=�6x   $��26��6�   $��89��6�   d� 5Y      -   5        $ btnActividadFisicaMas4h��5Y   +   
����������	#FF7B95E6$��>=4h/sem  0��6v   $
��Left=�6�   $	��Top=�6�   $��34��6�   $
��78.5��6�   $
��Bold"�6�   6�   d� 5Z      -   5        $ btnActividadFisicaMenos4h��5Z   +   
����������	#FF7B95E6$��<4h/sem  +2��6x   $
��Left=�6�   $	��Top=�6�   $��34��6�   $
��78.5��6�   $
��Bold"�6�   6�   5[      �� 5\      $ 
Horizontal=�6%   $��6��6>   $��0��6K   $��Bottom=�6[   $��Right=�6v   $��2q�6�   .+�5]      �� $'��!Consumo diario de frutas/verduras��6$   $��6��6P   $��0��6]   $��Center=�6m   $��26��6�   $	��177��6�   $��11(�6�   d� 5^      -   5        $ btnNoConsumoFrutas��5^   +   
����������	#FF7B95E6$��No        +2��6q   $
��Left=�6�   $	��Top=�6�   $��34��6�   $
��78.5��6�   $
��Bold"�6�   6�   d� 5_      -   5        $ btnSiConsumoFrutas��5_   +   
����������	#FF7B95E6$��Si          0��6q   $
��Left=�6�   $	��Top=�6�   $��34��6�   $
��78.5��6�   $
��Bold"�6�   6�   5`      �� 5a      $ 
Horizontal=�6%   $��1��6>   $��2��6K   $��Center=�6[   $��Center=�6v   $��2q�6�   .+�5b      �� $��Peso:��6$   $��0��64   $��1��6A   $��Right=�6Q   $��Center=�6t   $��26��6�   $��50��6�   �� 5c      -   5         ��Name$ txtPeso��5c   &   $��0��67   $��1��6D   $��Right=�6T   	 �� TextWrapping$
	 Wrap=�6p   $��Center=�6�   $	��158��6�   $��26��6�   6�   �� 5d      $��kg��6$   $
��Left=�61   $��Center=�6L   $��26��6g   $��26��6s   5e      �� 5f      $ 
Horizontal=�6%   $��2��6>   $��2��6K   $��Center=�6[   $��Center=�6v   $��2q�6�   .+�5g      �� $��Altura:��6$   $
��Left=�66   $��Right=�6Q   $	��Top=�6t   $��26��6�   $��50��6�   �� 5h      -   5        $ 	txtAltura��5h   &   $
��Left=�69   $
	 Wrap=�6T   $	��Top=�6h   $	��158��6�   $��26��6�   6�   �� 5i      $��cm��6$   $
��Left=�61   $	��Top=�6L   $��26��6d   $��26��6p   5j      �� 5k      $ 
Horizontal=�6%   $��3��6>   $��2��6K   $��Center=�6[   $��Center=�6v   $��2q�6�   .+�5l      �� $��Cintura:��6$   $
��Left=�67   $��Right=�6R   $	��Top=�6u   $��26��6�   $��50��6�   �� 5m      -   5        $ 
txtCintura��5m   &   $
��Left=�6:   $
	 Wrap=�6U   $	��Top=�6i   $	��158��6�   $��26��6�   6�   �� 5n      $��cm��6$   $
��Left=�61   $	��Top=�6L   $��26��6d   $��26��6p   5o      �� 5p      $ 
Horizontal=�6%   $��4��6>   $��1��6K   $��Bottom=�6[   $��Right=�6v   $��2q�6�   .+�5q      �� $#��Antecedentes de hiperglucemia��6$   $��3��6L   $��1��6Y   $
��Left=�6i   $��Center=�6�   $��26��6�   $	��178��6�   d� 5r      -   5        $$ btnAntecedentesHiperglucemiaNo��5r   +   
����������	#FF7B95E6$��No         0��6}   $
��Left=�6�   $	��Top=�6�   $��34��6�   $��76��6�   $
��Bold"�6�   6�   d� 5s      -   5        $$ btnAntecedentesHiperglucemiaSi��5s   +   
����������	#FF7B95E6$��Si        +2��6}   $
��Left=�6�   $	��Top=�6�   $��34��6�   $��76��6�   $
��Bold"�6�   6�   5t      �� 5u      $ 
Horizontal=�6%   $��5��6>   $��1��6K   $��Bottom=�6[   $��Right=�6v   $��2q�6�   .+�5v      �� $#��Medicación presión arterial��6$   $
��Left=�6J   $��4��6e   $��1��6r   $��Center=�6�   $��26��6�   $	��154��6�   d� 5w      -   5        $ btnMedicacionArterialNo��5w   +   
����������	#FF7B95E6$��No         0��6v   $
��Left=�6�   $	��Top=�6�   $��34��6�   $��76��6�   $
��Bold"�6�   6�   d� 5x      -   5        $ btnMedicacionArterialSi��5x   +   
����������	#FF7B95E6$��Si        +2��6v   $
��Left=�6�   $	��Top=�6�   $��34��6�   $��76��6�   $
��Bold"�6�   6�   5y      �� 5z      $)��#Antecedentes familiares de diabetes��6    $��Center=�6N   $��0��6k   $��1��6x   $��Bottom=�6�   $��26��6�   $	��201��6�   �� 5{      $ 
Horizontal=�6%   $��1��6>   $��1��6K   $��Center=�6[   $��Center=�6v   .+�5|      �� $�� ��6$   $
��Left=�6/   $��Center=�6J   $��26��6e   $	��195��6q   d� 5}      -   5        $ btnNoAntecedentesDiabetes��5}   +   
����������	#FF7B95E6$)��#No                                0��6x   $��34��6�   $	��137��6�   $
��Bold"�6�   6�   5~      �� 5      $ 
Horizontal=�6%   $��2��6>   $��1��6K   $��Center=�6[   $��Center=�6v   .+�5�      �� $��Abuelos, tíos o primos��6$   $��Right=�6E   $��Right=�6a   $��Center=�6�   $��26��6�   $	��195��6�   d� 5�      -   5        $# btnPrimosAntecedentesDiabetes��5�   +   
����������	#FF7B95E6$*��$Si                                +3��6|   $
��Left=�6�   $	��Top=�6�   $��34��6�   $	��137��6�   $
��Bold"�6�   6  5�      �� 5�      $ 
Horizontal=�6%   $��3��6>   $��1��6K   $��Center=�6[   $��Center=�6v   .+�5�      �� $��Padres o hermanos��6$   $
��Left=�6@   $��Right=�6[   $��Center=�6~   $��26��6�   $	��195��6�   d� 5�      -   5        $# btnPadresAntecedentesDiabetes��5�   +   
����������	#FF7B95E6$*��$Si                                +5��6|   $	��Top=�6�   $��34��6�   $	��137��6�   $
��Bold"�6�   6�   5�      �� 5�      -   5        $ btnCalcular��5�   !   
����������	#FF7B95E6$��2��6`   $��5��6p   $��Calcular��6}   $��Center=�6�   $	��Top=�6�   $��34��6�   $	��224��6�   $
��Bold"�6�   6�   �� 5�      $��2��6$   $
��Left=�64   $��	54,39,0,0q�6O   $��5��6b   $
��Wrap=�6o   $	��Top=�6�   $����*Si ya ha realizado alguna consulta le saldrán                                                                        los resultados de la última consulta.                                                                        Si lo desea, puede cambiar alguno de los valores.��6�   $��2��5�   W   $��10(�6h   5�      �� 5�      $ 
Horizontal=�6!   $��1��6:   $��Center=�6G   $
��Left=�6b   $��2q�6}   .+�5�      �� $��Puntuación:��6    ���	#FF625E84$��20(�6M   $
��Bold"�6[   $��37��6m   $	��128��6y   �� 5�      -   5        
 ��Name$
 tbPuntuacion��5�   $   $��1��6:   $�� ��6G   $��20(�6O   $��Center=�6]   $��Center=�6z   5�      �� 5�      $ 
Horizontal=�6!   $��2��6:   $��Center=�6G   $
��Left=�6b   $��2q�6}   .+�5�      �� $��Recomendación:��6    ���	#FF625E84$��2��6P   $
��Left=�6]   $	��Top=�6y   $��20(�6�   $
��Bold"�6�   $��37��6�   $	��165��6�   �� 5�      -   5        $
 tbRecomendacion��5�   $   $��2��6=   $�� ��6J   $��15(�6R   $��Center=�6`   $��Center=�6}   5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ 
imgUsuario��5�      $
��Left=�6$   $	��126��6?   $��	25,10,0,0q�6L   $	��Top=�6_   $	��136��6w   $��
perfil.jpg��6�   �� 5�   
   -   5        $ btnUltimosResultados��5�      $��Ver últimas consultas��6/   $��Center=�6O   $	��Top=�6l   $��Verdana)�6�   $��34��6�   $	��156��6�   $��	0,364,0,0q�6�   ���	#FF7B95E6$
��Bold"�6�   
����������	#FF7B95E66  5�      5�      