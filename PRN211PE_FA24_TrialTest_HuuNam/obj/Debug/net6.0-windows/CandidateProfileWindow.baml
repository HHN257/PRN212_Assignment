   M S B A M L   `   `   `  ����Y  UPRN211PE_FA24_TrialTest_HuuNam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:PRN211PE_FA24_TrialTest_HuuNamPRN211PE_FA24_TrialTest_HuuNam  5   	   ;    5PRN211PE_FA24_TrialTest_HuuNam.CandidateProfileWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:PRN211PE_FA24_TrialTest_HuuNam     5   	   -   5          � Title$  CandidateProfileWindow��5   	   $	��709��6(   $	��835��65    � WindowStyle$
 None=�6A   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $"��Candidate Profile Management��6   $��Center=�67   $��0,30,0,0q�6T   $	��Top=�6f   $��36(�6~   �� 5   
   $��Candidate ID��6   $
��Left=�6'   $��
43,161,0,0q�6B   $	��Top=�6V   $��16(�6n   �� 5   
   -   5         ��Name$ txtCandidateID��5      $
��Left=�6*   $��148,163,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��268��6�   $��27��6�   �� 5   
   $��Fullname��6   $
��Left=�6#   $��
43,207,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��
ProfileURL��6   $
��Left=�6%   $��
43,258,0,0q�6@   $	��Top=�6T   $��16(�6l   �� 5   
   -   5        $ txtFullname��5      $
��Left=�6'   $��148,209,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��268��6�   $��27��6�   �� 5   
   -   5        $ txtImageURL��5      $
��Left=�6'   $��148,260,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��268��6�   $��27��6�   �� 5   
   $��Birthday��6   $
��Left=�6#   $��
43,305,0,0q�6>   $	��Top=�6R   $��16(�6j   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtBirthday��5      $
��Left=�6*   $��148,307,0,0q�6E   $	��Top=�6Z   $	��268��6r   $��27��6~   �� 5   
   $��Job Posting��6   $
��Left=�6&   $��457,161,0,0q�6A   $	��Top=�6V   $��16(�6n   �� 5   
   $��Description��6   $
��Left=�6&   $��457,200,0,0q�6A   $	��Top=�6V   $��16(�6n   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��457,231,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��337��6�   $	��103��6�   �� 5   
   -   5         ��Name$ 	cmbPostID��5      $
��Left=�6&   $��571,163,0,0q�6A   $	��Top=�6V   $	��223��6n   $��27��6z   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgCandidateProfile��5      $��0,369,0,143q�6[   6p   �� 5   
   -	   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
71,594,0,0q�6J   $	��Top=�6^   $��38��6v   $	��105��6�   ���	#FF35E60B6�   �� 5   
   -
   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��254,594,0,0q�6P   $	��Top=�6e   $��38��6}   $	��104��6�   ���	#FFEDF0196�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��443,594,0,0q�6P   $	��Top=�6e   $��38��6}   $	��104��6�   ���	#FFE830306�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��630,594,0,0q�6N   $	��Top=�6c   $��38��6{   $	��104��6�   ���	#FF1EF0E06�   5      5      