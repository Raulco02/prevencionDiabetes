   M S B A M L   `   `   `  ����M  IprevencionDiabetes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:prevencionDiabetesprevencionDiabetes  5   	   "    prevencionDiabetes.Historial   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:prevencionDiabetes     5   	     � Title$  	Historial��5   	    � 
ResizeMode$ NoResize=�6   $	��470��61   $
��1201��6>    � 	Resources 5	       �� 
TargetType   	sexoStyle �� Triggers �� Binding �� Value �� Property �� Value  MedicacionToSiNoStyle  antHiperglucemiaToSiNoStyle  actFisicaStyle  consumoFYVToSiNoStyle  antFamiliaresStyle  resultadoStyle  TemplatePaciente	 �� Orientation��%�  &	        &	 �     &	     &	     &	 ,    &	 .    &	 �    &	 �    7   7  7  7  7  7  7  �� 5
   
   " ��6    5      �� 5       6   �� *Sexo+ True67   .a�5      ��  � ��$ Mujer��60   5      �� 5       6   �� *Sexo+	 False67   .a�5      ��  � ��$ Hombre��60   5      5      �� 5   
   " ��6    5      �� 5       6   �� *MedicacionPA+ True6?   .a�5      ��  � ��$	 Sí��60   5      �� 5       6   �� *MedicacionPA+	 False6?   .a�5      ��  � ��$ No��60   5      5      �� 5   
   " ��6    5      �� 5        6   �� *ActHipoglucemia+ True6B   .a�5!      ��  � ��$	 Sí��60   5"      �� 5#       6   �� *ActHipoglucemia+	 False6B   .a�5$      ��  � ��$ No��60   5%      5'      �� 5(   
   " ��6    5)      �� 5*       6   �� *	ActFisica+ True6<   .a�5+      ��  � ��$ Más de 4h/semana��60   5,      �� 5-       6   �� *	ActFisica+	 False6<   .a�5.      ��  � ��$ Menos de 4h/semana��60   5/      51      �� 52   
   " ��6    53      �� 54       6   �� *
ConsumoFYV+ True6=   .a�55      ��  � ��$	 Sí��60   56      �� 57       6   �� *
ConsumoFYV+	 False6=   .a�58      ��  � ��$ No��60   59      5;      �� 5<   
   " ��6    5=      �� 5>       6   �� *AntFamiliares+ 06@   .a�5?      ��  � ��$ No��60   5@      �� 5A       6   �� *AntFamiliares+ 16@   .a�5B      ��  � ��$ Tíos, primos, abuelos��60   5C      �� 5D       6   �� *AntFamiliares+ 26@   .a�5E      ��  � ��$ Padre, madre, hermanos��60   5F      5H      �� 5I   
   " ��6    5J      �� 5K       6   �� *	Resultado+ 06<   .a�5L      ��  � ��$E ?Bajo riesgo de diabetes. Sigue manteniendo hábitos saludables.��60   5M      �� 5N       6   �� *	Resultado+ 16<   .a�5O      ��  � ��$� �Ligeramente elevado riesgo de diabetes. Se recomienda hacer cambios en el estilo de vida y mantener una alimentación saludable.��60   5P      �� 5Q       6   �� *	Resultado+ 26<   .a�5R      ��  � ��$� �Moderado riesgo de diabetes. Es importante hacer cambios inmediatos en el estilo de vida, realiza ejercicio físico, mantén una dieta equilibrada y evita el consumo de alcohol y tabaco.��60   5S      �� 5T       6   �� *	Resultado+ 36<   .a�5U      ��  � ��$� �Alto riesgo de diabetes. Realiza ejercicio físico, mantén una dieta equilibrada, evita el consumo de alcohol y tabaco, visita al médico y realiza controles periódicos de glucemia.��60   5V      �� 5W       6   �� *	Resultado+ 46<   .a�5X      ��  � ��$� �Muy alto riesgo de diabetes. Es muy importante que visites al médico, mantengas una dieta equilibrada, realices actividad física, evites alcohol y tabaco y que realices controles de glucemia frecuentes.��60   5Y      5[      �� 5\   
   .R�5]      �� .+�5^      �� $	 
Horizontal=�6   .+�5_      �� $��Sexo: ��6   �� 5`      8��  6   5a      �� 5b      $	 
Horizontal=�6   .+�5c      �� $��Peso: ��6   �� 5d      ��6   �� *Peso+5e      �� 5f      $	 
Horizontal=�6   .+�5g      �� $��Altura: ��6   �� 5h      ��6   �� *Altura+5i      �� 5j      $	 
Horizontal=�6   .+�5k      �� $��	Cintura: ��6   �� 5l      ��6   �� *	Cintura+5m      �� 5n      $	 
Horizontal=�6   .+�5o      �� $%��Medicación presión arterial: ��6   �� 5p      8�� 6   5q      �� 5r      $	 
Horizontal=�6   .+�5s      �� $%��Antecedentes de hiperglucemia: ��6   �� 5t      8�� 6   5u      �� 5v      $	 
Horizontal=�6   .+�5w      �� $��Actividad física: ��6   �� 5x      8�� 6   5y      �� 5z      $	 
Horizontal=�6   .+�5{      �� $-��'Consumo habitual de frutas y verduras: ��6   �� 5|      8�� 6   5}      �� 5~      $	 
Horizontal=�6   .+�5      �� $��Antecedentes familiares: ��6   �� 5�      8�� 6   5�      �� 5�      $	 
Horizontal=�6   .+�5�      �� $��Puntos: ��6   �� 5�      ��6   �� *PuntosFindrisk+5�      �� 5�      $	 
Horizontal=�6   .+�5�      �� $��Recomendación: ��6   �� 5�      8�� 6   5�      5�      5�      5�      .��5�      � -   5        
 �Name$
 miGrid��5�       � RowDefinitions 5�   
   �� 5�      $	��30* �6   �� 5�      $��5* �6   .+�5�   
   �� $
��Auto=�6   $��0��6:   .��5�      �� -   5         ��Name$ listaPacientes��5�      5�      �� 5�   
   $��1��6   $	 
Horizontal=�6"   .+�5�      �� $��Resumen:��6   ���	#FF625E84$
��Left=�6>   $	��Top=�6Z   $��20(�6r   $
��Bold"�6�   $��37��6�   $	��100��6�   �� 5�      -   5         ��Name$ 	tbResumen��5�      $����Tu puntuación respecto ha empeorado.Visita al médico. Mejora alimentación, realiza actividad física y mantén buenos hábitos.��6+   $��55��6�   $
��1098��6�   $��20(�6�   $��0,5,0,0q�6�   $	��Top=�6�   $
��Wrap=�6   5�      5�      5�      