### XAM120 - Demo4 : 전화걸기 UI 만들기 

## StackLayout 경우

1. StackLayout 선언
```
<StackLayout Spacing="15">    
</StackLayout>
```

2. Label, Entry, Button 추가
```
<Label Text="전화번호 입력:" FontSize="Large"/>
<Entry Text="010-1234-5678" x:Name="phoneNumberText"/>
<Button Text="전화걸기"/>
```

## GridLayout 경우 
1. GridLayout 선언 
```
<Grid>
</Grid>
```
2. Row Definition 선언
```
<Grid.RowDefinitions>
    <RowDefinition Height="Auto" />
    <RowDefinition Height="Auto" />
    <RowDefinition Height="Auto" />
</Grid.RowDefinitions>
```        
3.Label, Entry, Button 추가
```
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Label Text="전화번호 입력:" FontSize="Large"/>
    <Entry Text="010-1234-5678" x:Name="phoneNumberText" Grid.Row="1"/>
    <Button Text="전화걸기" Grid.Row="2"/>
</Grid>
```

## Margin 알아보기
1. Label에 Margin적용
```
<Label Text="전화번호 입력:" FontSize="Large" Margin="30"/>
```
2. Entry에 Margin적용
```
<Entry Text="010-1234-5678" x:Name="phoneNumberText" Grid.Row="1" Margin="30"/>
```
Lesson Learn: Margin은 인근의 View와의 간격을 조정할 때 사용한다.

## Padding 알아보기
Grid에 Padding 적용
```
<Grid Padding="30">
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Label Text="전화번호 입력:" FontSize="Large"/>
    <Entry Text="010-1234-5678" x:Name="phoneNumberText" Grid.Row="1"/>
    <Button Text="전화걸기" Grid.Row="2"/>
</Grid>
```
Lesson Learn: Padding은 Layout Container와의 간격을 조정할 때 사용한다.

## Spacing 알아보기
StackLayout 에 Spacing 적용
```
<StackLayout Spacing="30">
    <Label Text="전화번호 입력:" FontSize="Large"/>
    <Entry Text="010-1234-5678" x:Name="phoneNumberText"/>
    <Button Text="전화걸기"/>
</StackLayout>    
```
Lesson Learn: Spacing은 StackLayout 내부의 요소들간의 간격을 조정할 때 사용한다.
