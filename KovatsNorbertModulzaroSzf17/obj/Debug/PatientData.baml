   M S B A M L   `   `   `  ����V  RKovatsNorbertModulzaroSzf17, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:KovatsNorbertModulzaroSzf17KovatsNorbertModulzaroSzf17  5   	   -    'KovatsNorbertModulzaroSzf17.PatientData   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:KovatsNorbertModulzaroSzf17     5   	     � Title$  PatientData��5   	   $��221.893��6   $��369.231��6.   .��5	      � .+�5
   
   �� $��Beteg neve:��6   $
��Left=�6&   $	��Top=�6A   $��	10,10,0,0q�6Y   �� 5   
   $��Születési hely:��6   $
��Left=�6*   $	��Top=�6E   $��	10,41,0,0q�6]   �� 5   
   $��Születési dátum:��6   $
��Left=�6+   $	��Top=�6F   $��	10,72,0,0q�6^   �� 5   
   $��	Életkor:��6   $
��Left=�6#   $	��Top=�6>   $��
269,71,0,0q�6V   �� 5   
   $��
Taj szám:��6   $
��Left=�6$   $	��Top=�6?   $��	10,98,0,0q�6W   �� 5   
   -   5        $��OK��5      $
��Left=�6   $	��Top=�69   $	��139��6Q   $��123,161,0,0q�6]   6r   �� 5   
   -   5         ��Name$ patientNameTextBox��5      $
��Left=�6L   $��23��6g    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��228��6�   $��
123,14,0,0q�6�   ��6.   �� *Patient.Name+6�   �� 5   
   -   5        $ patientBLocationTextBox��5      $
��Left=�6W   $��23��6r   $
 Wrap=�6~   $	��Top=�6�   $	��228��6�   $��
123,44,0,0q�6�   ��63   �� *Patient.BLocation+6�   �� 5   
   -   5        $ patientTAJTextBox��5   W    �� MinLines$ 9��6=    �� MaxLines$ 9��6J   $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��228��6�   $��123,101,0,0q�6�   ��6r   �� *Patient.TAJ+6  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ patientBDateDatePicker��5      $
��Left=�6\   $��
123,72,0,0q�6w   $	��Top=�6�      SelectedDate 65   �� *Patient.BDate+6�   �� 5   
   $
��Left=�60   $	��Top=�6K   $��
318,72,0,0q�6c    J� RenderTransformOrigin$ 1.173,1.727&�6w   $��24��6�   $��28��6�   ��6   �� *Patient.Age+6�   5      5      