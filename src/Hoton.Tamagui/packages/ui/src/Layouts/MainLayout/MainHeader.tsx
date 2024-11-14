'use client'

import { Menu, ArrowLeft } from '@tamagui/lucide-icons'
import { useRouter } from 'solito/navigation'
import { Stack, XStack, H4, Button } from 'tamagui'

interface AppBarProps {
  title?: string
  onMenuPress?: () => void
  showBack?: boolean
}

export const MainHeader = ({ 
  title = '', 
  onMenuPress,
  showBack
}: AppBarProps) => {
  const router = useRouter()
  
  const handleBack = () => {
    router.back()
  }

  return (
    <Stack
      backgroundColor="$background"
      borderBottomWidth={1}
      borderBottomColor="$borderColor"
    >
      <XStack
        height={56}
        alignItems="center"
        paddingHorizontal="$4"
        gap="$4"
      >
        <Button
          size="$3"
          circular
          transparent
          onPress={showBack ? handleBack : onMenuPress}
          icon={showBack ? ArrowLeft : Menu}
        />
        
        <H4 flex={1} textAlign="center">
          {title}
        </H4>
        
        {/* Placeholder to center title */}
        <Button size="$3" circular transparent opacity={0} />
      </XStack>
    </Stack>
  )
}